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
using Lumos.GUI.Input.v2;
using LumosLIB.Kernel.Scene.Fanning;
using org.dmxc.lumos.Kernel.PropertyType;
using LumosLIB.Tools;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using ErrorEventArgs = LumosLIB.Kernel.Plugin.ErrorEventArgs;

namespace Lumos3DconnexionPlugin
{
    /// <summary>
    /// Plugin Class. Inhertited from GuiPluginBase
    /// </summary>
    public class _3DxPlugin : Lumos.GUI.Plugin.GuiPluginBase, IResourceProvider
    {
        /// <summary>
        /// Every Plugin needs a unique ID
        /// </summary>
        const string PLUGIN_ID = "{6C1AC89E-BBED-4D76-9D63-54FEFA74BF15}";

        public const string PLUGIN_NAME = "3Dconnexion";

        private static readonly ILumosLog log = LumosLogger.getInstance<_3DxPlugin>();
        private static readonly LumosResourceMetadata SETTINGS_FILE = new LumosResourceMetadata("_3DxPluginSettings.xml", ELumosResourceType.MANAGED_TREE);

        private _3DxForm _form;
        private int exceptionCounter;

        private readonly Dictionary<E3DxAchsis, _3DxInputSource> _inputSources = Enum.GetValues(typeof(E3DxAchsis))
            .Cast<E3DxAchsis>().Select(c => new _3DxInputSource(c)).ToDictionary(c => c.Axis);

        public _3DxPlugin() 
            : base(PLUGIN_ID, PLUGIN_NAME + " Plugin") 
        { 



        }

        /// <summary>
        /// Initialize Plugin. This is called once when Plugin is created @ Startup
        /// </summary>
        protected override void initializePlugin()
        {
            this._form = new _3DxForm();
            this._form.DeviceMotion += _form_DeviceMotion;
            this._form.PluginError += _form_PluginError;
            this.loadSettings();

            ResourceManager.getInstance().registerResourceProvider(this);
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
            InputManager.getInstance().UnregisterSources(_inputSources.Values);
        }

        /// <summary>
        /// This is called when Plugin is enabled (e.g. startup of DMXC or Plugin enabled by user)
        /// </summary>
        protected override void startupPlugin()
        {
            WindowManager.getInstance().AddWindow(this._form);
            this._form.PluginEnabled = true;
            this.exceptionCounter = 0;

            InputManager.getInstance().RegisterSources(_inputSources.Values);
        }

        /// <summary>
        /// Called when a connection to a Kernel has been established
        /// </summary>
        public override void connectionEstablished()
        {
            base.connectionEstablished();
        }

        /// <summary>
        /// Called when connection to Kernel is closing
        /// </summary>
        public override void connectionClosing()
        {
            base.connectionClosing();
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
            }
            LumosResource r = new LumosResource(SETTINGS_FILE.Name, i);
            ResourceManager.getInstance().saveResource(EResourceType.APPLICATION, r);
        }

        protected override void DisposePlugin(bool disposing)
        {
            base.DisposePlugin(disposing);
            if (_form != null)
            {
                _form.PluginEnabled = false;
                _form.Dispose();
                _form = null;
            }
        }

        private void _form_PluginError(object sender, ExceptionEventArgs e)
        {
            exceptionCounter++;
            bool? status = null;
            if (exceptionCounter >= 5)
                status = false;
            OnPluginError(new ErrorEventArgs(status, e.ExceptionObject));
        }

        #region Dispatch 3Dx Value to Lumos

        

        private void _form_DeviceMotion(object sender, _3DxMotionEventArgs e)
        {
            foreach (var kvp in e.AxisValues)
            {
                var p = _inputSources.TryGetWithDefault(kvp.Key);
                p?.SetValue(kvp.Value);
            }
        }

        public bool existsResource(EResourceDataType type, string name)
        {
            if (type == EResourceDataType.SYMBOL)
            {
                if (name.Equals("3DxIcon") || name.Equals("3DxIcon_16") || name.Equals("3DxIcon_32"))
                    return true;
            }
            return false;
        }

        public ReadOnlyCollection<LumosDataMetadata> allResources(EResourceDataType type)
        {
            if (type == EResourceDataType.SYMBOL)
            {
                List<LumosDataMetadata> ret = new List<LumosDataMetadata>()
                {
                    new LumosDataMetadata("3DxIcon"),
                    new LumosDataMetadata("3DxIcon_16"),
                    new LumosDataMetadata("3DxIcon_32"),
                };
                return ret.AsReadOnly();
            }

            return null;
        }

        public byte[] loadResource(EResourceDataType type, string name)
        {
            if (type == EResourceDataType.SYMBOL)
            {
                switch (name)
                {
                    case "3DxIcon":
                    case "3DxIcon_32":
                        return (byte[]) Properties.Resources._3DxIcon_32_png.Clone();

                    case "3DxIcon_16":
                        return (byte[]) Properties.Resources._3DxIcon_16_png.Clone();
                }
            }

            return null;
        }

        #endregion
    }

    public enum E3DxAchsis
    {
        TX, TY, TZ, RX, RY, RZ
    }
}
