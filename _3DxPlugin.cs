using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lumos.GUI;
using LumosLIB.Kernel.Log;
using org.dmxc.lumos.Kernel.Resource;
using Lumos.GUI.Resource;
using org.dmxc.lumos.Kernel.DeviceProperties;
using Lumos.GUI.Connection;
using Lumos.GUI.Facade.DeviceProperties;
using LumosLIB.Kernel.Scene.Fanning;
using org.dmxc.lumos.Kernel.PropertyType;
using LumosLIB.Tools;

namespace Lumos3DconnexionPlugin
{
    /// <summary>
    /// Plugin Class. Inhertited from GuiPluginBase
    /// </summary>
    public class _3DxPlugin : Lumos.GUI.Plugin.GuiPluginBase
    {
        const string PLUGIN_ID = "{6C1AC89E-BBED-4D76-9D63-54FEFA74BF15}";

        private static readonly ILumosLog log = LumosLogger.getInstance<_3DxPlugin>();
        private static readonly LumosResourceMetadata SETTINGS_FILE = new LumosResourceMetadata("_3DxPluginSettings.xml", ELumosResourceType.MANAGED_TREE);

        private _3DxForm _form;

        public _3DxPlugin() 
            : base(PLUGIN_ID, "3Dconnexion Plugin") 
        { 
        }

        /// <summary>
        /// Initialize Plugin. This is called once when Plugin is created @ Startup
        /// </summary>
        protected override void initializePlugin()
        {
            this._form = new _3DxForm();
            this._form.DeviceMotion += new EventHandler<_3DxMotionEventArgs>(_form_DeviceMotion);
            this.loadSettings();
        }

        /// <summary>
        /// This is called when Plugin needs to stop (e.g. shutdown of DMXC, or Plugin is disabled by user)
        /// </summary>
        protected override void shutdownPlugin()
        {
            this.saveSettings();
            if (this._form != null)
            {
                WindowManager.getInstance().RemoveWindow(this._form);
                this._form.PluginEnabled = false;
                this._form.Hide();
            }
        }

        /// <summary>
        /// This is called when Plugin is enabled (e.g. startup of DMXC or Plugin enabled by user)
        /// </summary>
        protected override void startupPlugin()
        {
            WindowManager.getInstance().AddWindow(this._form);
            this._form.PluginEnabled = true;
        }

        /// <summary>
        /// Called when a connection to a Kernel has been established
        /// </summary>
        public override void connectionEstablished()
        {
            base.connectionEstablished();
            ConnectionManager.getInstance().GuiSession.SelectedDeviceGroupChanged += onSelectedDeviceGroupChanged;
        }

        /// <summary>
        /// Called when connection to Kernel is closing
        /// </summary>
        public override void connectionClosing()
        {
            base.connectionClosing();

            ClearAllFacades();

            var s = ConnectionManager.getInstance().GuiSession;
            if (s != null)
                s.SelectedDeviceGroupChanged -= onSelectedDeviceGroupChanged;
        }

        private void loadSettings()
        {
            //Check whether ResourceManager has a setting
            if (ResourceManager.getInstance().existsResource(EResourceType.APPLICATION, SETTINGS_FILE))
            {
                var r = ResourceManager.getInstance().loadResource(EResourceAccess.READ, EResourceType.APPLICATION, SETTINGS_FILE);
                if (r.ManagedData != null)
                {
                    //Loop through all axis and load settings if existing
                    foreach (E3DxAchsis a in Enum.GetValues(typeof(E3DxAchsis)))
                    {
                        if (r.ManagedData.hasValue<int>(a.ToString() + "-Deadzone"))
                            this._form.SetAxisDeadzone(a, r.ManagedData.getValue<int>(a.ToString() + "-Deadzone"));
                        else
                            this._form.SetAxisDeadzone(a, 0);

                        if (r.ManagedData.hasValue<EPropertyType>(a.ToString() + "-Property"))
                            this._form.SetMappedProperty(a, r.ManagedData.getValue<EPropertyType>(a.ToString() + "-Property"));
                        else
                            this._form.SetMappedProperty(a, null);
                    }
                }
            }
        }

        private void saveSettings()
        {
            //Create new ManagedTreeItem
            ManagedTreeItem i = new ManagedTreeItem("3DxPlugin");
            //Loop through all axis and save settings
            foreach (E3DxAchsis a in Enum.GetValues(typeof(E3DxAchsis)))
            {
                int dz = this._form.GetAxisDeadzone(a);
                i.setValue(a.ToString() + "-Deadzone", dz);
                var pt = this._form.GetMappedProperty(a);
                if (pt != null)
                    i.setValue(a.ToString() + "-Property", pt.Value);
            }
            LumosResource r = new LumosResource(SETTINGS_FILE.Name, i);
            ResourceManager.getInstance().saveResource(EResourceType.APPLICATION, r);
        }

        #region Dispatch 3Dx Value to Lumos

        private readonly IncrementSupport _goboIncrement = new IncrementSupport(10000) { ResetOnDirectionChange = true },
            _shutterIncrement = new IncrementSupport(10000) { ResetOnDirectionChange = true };

        private IDevicePropertyFacade _goboFacade, _colorFacade, _positionFacade, _zoomFacade, _dimmerFacade, _shutterFacade;
        private Position _positionLB, _positionHB;
        private double _intensityLB, _intensityHB;
        private double _zoomLB, _zoomHB;
        private readonly List<Gobo> _goboGobos = new List<Gobo>();

        private void ClearAllFacades()
        {
            _goboFacade = _colorFacade = _positionFacade = _zoomFacade = _dimmerFacade = _shutterFacade = null;
            _goboIncrement.Reset();
            _shutterIncrement.Reset();
        }

        private void onSelectedDeviceGroupChanged(Object sender, EventArgs e)
        {
            if (!ConnectionManager.getInstance().Connected) return;

            var s = ConnectionManager.getInstance().GuiSession;
            var deviceGroup = s.SelectedDeviceGroup;

            ClearAllFacades();

            if (deviceGroup != null)
            {
                foreach (var prop in deviceGroup.GUIProperties)
                {
                    switch (prop.PropertyType)
                    {
                        case EPropertyType.Dimmer: 
                            _dimmerFacade = prop;
                            _intensityLB = (double)prop.LowerBound;
                            _intensityHB = (double)prop.UpperBound;
                            break;
                        case EPropertyType.Zoom: 
                            _zoomFacade = prop;
                            _zoomLB = (double)prop.LowerBound;
                            _zoomHB = (double)prop.UpperBound;
                            break;
                        case EPropertyType.Position: 
                            _positionFacade = prop; 
                            _positionLB = (Position)prop.LowerBound;
                            _positionHB = (Position)prop.UpperBound; 
                            break;
                        case EPropertyType.Color: _colorFacade = prop; break;
                        case EPropertyType.Gobo: 
                            _goboFacade = prop;
                            _goboGobos.Clear();
                            var propertyEnum = prop.MergedGUIPropertyType as IGUIEnumPropertyType;
                            _goboGobos.AddRange(propertyEnum.EnumValues.OfType<Gobo>());
                            break;
                        case EPropertyType.Shutter: _shutterFacade = prop; break;
                    }
                }
            }
        }

        private void _form_DeviceMotion(object sender, _3DxMotionEventArgs e)
        {
            int pan = 0, tilt = 0;
            foreach (var kvp in e.AxisValues)
            {
                switch (kvp.Key)
                {
                    case EPropertyType.Gobo: SetGoboValue(kvp.Value); break;
                    case EPropertyType.Color: SetColorValue(kvp.Value); break;
                    case EPropertyType.Dimmer: SetDimmerValue(kvp.Value); break;
                    case EPropertyType.Pan: pan = kvp.Value; break;
                    case EPropertyType.Tilt: tilt = kvp.Value; break;
                    case EPropertyType.Zoom: SetZoomValue(kvp.Value); break;
                }
            }
            if (pan != 0 || tilt != 0)
                SetPanTiltValue(pan, tilt);
        }

        private void SetGoboValue(int value)
        {
            if (_goboFacade == null) return;
            if (_goboGobos.Count == 0) return;

            if (_goboIncrement.Increment(value))
            {
                var g = _goboFacade.ProgrammerValue as Gobo;
                int oldIndex = -1;
                if (g == null || (oldIndex = _goboGobos.IndexOf(g)) < 0)
                {
                    _goboFacade.ProgrammerValue = _goboGobos[0];
                }
                else
                {
                    if (value > 0)
                        oldIndex = (oldIndex + 1) % _goboGobos.Count;
                    else
                    {
                        oldIndex--;
                        if (oldIndex < 0) oldIndex += _goboGobos.Count;
                    }
                    _goboFacade.ProgrammerValue = _goboGobos[oldIndex];
                }
            }
        }

        private void SetColorValue(int value)
        {
            if (_colorFacade == null) return;

            ColorFannedValue v = _colorFacade.ProgrammerValue as ColorFannedValue;
            if (v == null || v.Values.NullToEmpty().All(c => c.ColorsEqual(System.Drawing.Color.White)))
                _colorFacade.ProgrammerValue = ColorFannedValue.FromColor(System.Drawing.Color.Red);
            else
            {
                var c = v.rotate((double)value / 250);

                _colorFacade.ProgrammerValue = c;
            }
        }

        private void SetPanTiltValue(int panvalue, int tiltvalue)
        {
            if (_positionFacade == null) return;

            PositionFannedValue v = _positionFacade.ProgrammerValue as PositionFannedValue;
            if (v == null)
                _positionFacade.ProgrammerValue = PositionFannedValue.FromPosition(new Position(0, 0));
            else
            {
                var c = v.add((double)panvalue / 250, (double)tiltvalue / 250);
                if (!c.isInRange(_positionLB, _positionHB))
                    c = c.trimToRange(_positionLB, _positionHB);

                _positionFacade.ProgrammerValue = c;
            }
        }

        private void SetZoomValue(int value)
        {
            if (_zoomFacade == null) return;

            NumericFannedValue v = _zoomFacade.ProgrammerValue as NumericFannedValue;
            if (v == null)
            {
                _zoomFacade.ProgrammerValue = NumericFannedValue.FromInt(0);
            }
            else
            {
                var c = v.add((double)value / 100);
                if (!c.isInRange(_zoomLB, _zoomHB))
                    c = c.trimToRange(_zoomLB, _zoomHB);

                _zoomFacade.ProgrammerValue = c;
            }
        }

        private void SetDimmerValue(int value)
        {
            if (_dimmerFacade == null && _shutterFacade == null) return;

            if (_dimmerFacade != null)
            {
                NumericFannedValue v = _dimmerFacade.ProgrammerValue as NumericFannedValue;
                if (v == null)
                {
                    _dimmerFacade.ProgrammerValue = NumericFannedValue.FromInt(0);
                    if(_shutterFacade != null)
                        _shutterFacade.ProgrammerValue = false;
                }
                else
                {
                    var c = v.add((double)value / 500);
                    if (!c.isInRange(_intensityLB, _intensityHB))
                        c = c.trimToRange(_intensityLB, _intensityHB);

                    _dimmerFacade.ProgrammerValue = c;
                    if(_shutterFacade != null)
                        _shutterFacade.ProgrammerValue = c.LB > 0 || c.HB > 0;
                }
            }
            else if(_shutterFacade != null)
            {
                if (_shutterIncrement.Increment(value))
                {
                    _shutterFacade.ProgrammerValue = value > 0;
                }
            }
        }

        #endregion
    }

    public enum E3DxAchsis
    {
        TX, TY, TZ, RX, RY, RZ
    }
}
