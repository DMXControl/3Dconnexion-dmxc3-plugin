using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lumos.GUI.BaseWindow;
using LumosLIB.Kernel.Log;
using LumosLIB.Tools;
using org.dmxc.lumos.Kernel.DeviceProperties;

namespace Lumos3DconnexionPlugin
{
    public partial class _3DxForm : ToolWindow
    {
        private const string DISABLED_STRING = "Disabled";
        private const int NUD_MAX = 5000;

        private readonly _3DconnexionDriver._3DconnexionDevice _device;

        private int deviceId;
        private readonly System.Windows.Forms.Timer _3dxDeviceTimer = new System.Windows.Forms.Timer();
        private readonly System.Windows.Forms.Timer _eventTimer = new System.Windows.Forms.Timer();

        private int Tx, Ty, Tz, Rx, Ry, Rz;
        private bool changeFlag;

        private readonly ILumosLog _exceptionLog;

        internal event EventHandler<_3DxMotionEventArgs> DeviceMotion;
        internal event EventHandler<ExceptionEventArgs> PluginError; 

        public _3DxForm()
        {
            InitializeComponent();

            this.TabText = this.Text = _3DxPlugin.PLUGIN_NAME;
            this.MenuIconKey = "3DxIcon";
            this.Icon = Image.FromStream(Properties.Resources._3DxIcon_16_png.ToMS()).ImageToIcon();

            _exceptionLog = new SingleExceptionDecorator(log)
            {
                ReLogCount = 10
            };

            _device = new _3DconnexionDriver._3DconnexionDevice("DMXC3_3DxPlugin");

            _device.Motion += new EventHandler<_3DconnexionDriver.MotionEventArgs>(_device_Motion);
            _device.ZeroPoint += new EventHandler(_device_ZeroPoint);

            _3dxDeviceTimer.Interval = 2000;
            _3dxDeviceTimer.Tick += new EventHandler(_3dxDeviceTimer_Tick);

            _eventTimer.Interval = 100;
            _eventTimer.Tick += new EventHandler(_eventTimer_Tick);

            nudTx.Minimum = nudTy.Minimum = nudTz.Minimum =
                nudRx.Minimum = nudRy.Minimum = nudRz.Minimum = 0;

            nudTx.Maximum = nudTy.Maximum = nudTz.Maximum =
                nudRx.Maximum = nudRy.Maximum = nudRz.Maximum = NUD_MAX;
        }

        private void DisposeStuff()
        {
            DeviceMotion = null;
            PluginError = null;
        }

        private void _eventTimer_Tick(object sender, EventArgs e)
        {
            if (!changeFlag) return;

            _3DxMotionEventArgs args = new _3DxMotionEventArgs();
            foreach(E3DxAchsis a in Enum.GetValues(typeof(E3DxAchsis)))
            {
                int erg = CalcValue(GetAxisValue(a), GetAxisDeadzone(a));
                args.AxisValues[a] = erg;
            }

            if (args.AxisValues.Count > 0)
                OnDeviceMotion(args);

            changeFlag = false;
        }

        private int CalcValue(int axis, int deadzone)
        {
            if (Math.Abs(axis) > deadzone)
            {
                if (axis < 0)
                    return axis + deadzone;
                else
                    return axis - deadzone;
            }
            return 0;
        }

        private void MainFormWindow_WndProcHooks(Message obj)
        {
            try { _device.ProcessWindowMessage(obj.Msg, obj.WParam, obj.LParam); }
            catch (Exception e)
            {
                _exceptionLog.Debug("Error in WndProcHooks: {0}", e, e.Message);
                if (PluginError != null)
                    PluginError(this, new ExceptionEventArgs(e));
            }
        }

        private void _device_ZeroPoint(object sender, EventArgs e)
        {
            Tx = Ty = Tz = Rx = Ry = Rz = 0;
            UpdateMotionLables();
        }

        private void _device_Motion(object sender, _3DconnexionDriver.MotionEventArgs e)
        {
            Tx = e.TX;
            Ty = e.TY;
            Tz = e.TZ;
            Rx = e.RX;
            Ry = e.RY;
            Rz = e.RZ;
            UpdateMotionLables();
            changeFlag = true;
        }

        public int GetAxisValue(E3DxAchsis axis)
        {
            switch (axis)
            {
                case E3DxAchsis.TX: return this.Tx;
                case E3DxAchsis.TY: return this.Ty;
                case E3DxAchsis.TZ: return this.Tz;
                case E3DxAchsis.RX: return this.Rx;
                case E3DxAchsis.RY: return this.Ry;
                case E3DxAchsis.RZ: return this.Rz;
            }
            return 0;
        }

        public int GetAxisDeadzone(E3DxAchsis axis)
        {
            switch (axis)
            {
                case E3DxAchsis.TX: return (int)nudTx.Value;
                case E3DxAchsis.TY: return (int)nudTy.Value;
                case E3DxAchsis.TZ: return (int)nudTz.Value;
                case E3DxAchsis.RX: return (int)nudRx.Value;
                case E3DxAchsis.RY: return (int)nudRy.Value;
                case E3DxAchsis.RZ: return (int)nudRz.Value;
            }
            return 0;
        }

        public bool SetAxisDeadzone(E3DxAchsis axis, int zone)
        {
            if (zone < 0 || zone > NUD_MAX)
                return false;

            if (this.InvokeRequired)
            {
                return (bool) this.Invoke(new Func<E3DxAchsis, int, bool>(SetAxisDeadzone), axis, zone);
            }

            switch (axis)
            {
                case E3DxAchsis.TX: nudTx.Value = zone; return true;
                case E3DxAchsis.TY: nudTy.Value = zone; return true;
                case E3DxAchsis.TZ: nudTz.Value = zone; return true;
                case E3DxAchsis.RX: nudRx.Value = zone; return true;
                case E3DxAchsis.RY: nudRy.Value = zone; return true;
                case E3DxAchsis.RZ: nudRz.Value = zone; return true;
            }
            return false;
        }

        public bool PluginEnabled
        {
            get { return _3dxDeviceTimer.Enabled; }
            set
            {
                _3dxDeviceTimer.Enabled = value;
                _eventTimer.Enabled = value;
                if (!value)
                    _device.CloseDevice();

                //First deregister, then register to ensure Event is only registered once.
                Lumos.GUI.WindowManager.getInstance().MainFormWindow.WndProcHooks -= MainFormWindow_WndProcHooks;
                if (value)
                    Lumos.GUI.WindowManager.getInstance().MainFormWindow.WndProcHooks += MainFormWindow_WndProcHooks;
            }
        }

        private void _3dxDeviceTimer_Tick(object sender, EventArgs e)
        {
            if (!_device.IsAvailable)
                Init();
            //Detect Change
            else if(_device.DeviceID != this.deviceId)
                Init();
        }

        private void Init()
        {
            if (InvokeRequired)
                Invoke(new Action(Init));
            else
            {
                bool exception = false;
                try
                {
                    _device.InitDevice(Lumos.GUI.WindowManager.getInstance().MainFormWindow.Handle);
                    this.labelDeviceName.Text = _device.DeviceName;
                    this.labelFirmware.Text = _device.FirmwareVersion;
                    this.deviceId = _device.DeviceID;
                    string path = _device.IconPath;
                    if (!String.IsNullOrEmpty(path) && System.IO.File.Exists(path))
                    {
                        log.Debug("Loading DeviceImage from Path {0}", path);
                        Image i = Image.FromFile(path);
                        this.Icon = ImageTools.ImageToIcon(i);
                        this.pictureBoxDevice.Image = i;
                    }
                }
                catch (_3DconnexionDriver._3DxException e)
                {
                    this.labelError.Text = e.Message;
                    exception = true;
                }
                this.labelDeviceName.Visible = this.labelFirmware.Visible = this.pictureBoxDevice.Visible =
                    this.checkBoxLED.Visible = !exception;
                this.labelError.Visible = exception;
            }
        }

        private void UpdateMotionLables()
        {
            if (InvokeRequired)
                BeginInvoke(new Action(UpdateMotionLables));
            else
            {
                this.labelTx.Text = "TX: " + this.Tx;
                this.labelTy.Text = "TY: " + this.Ty;
                this.labelTz.Text = "TZ: " + this.Tz;
                this.labelRx.Text = "RX: " + this.Rx;
                this.labelRy.Text = "RY: " + this.Ry;
                this.labelRz.Text = "RZ: " + this.Rz;

                if (Math.Abs(this.Tx) > this.nudTx.Value)
                    this.labelTx.ForeColor = Color.Red;
                else
                    this.labelTx.ForeColor = Color.Black;

                if (Math.Abs(this.Ty) > this.nudTy.Value)
                    this.labelTy.ForeColor = Color.Red;
                else
                    this.labelTy.ForeColor = Color.Black;

                if (Math.Abs(this.Tz) > this.nudTz.Value)
                    this.labelTz.ForeColor = Color.Red;
                else
                    this.labelTz.ForeColor = Color.Black;

                if (Math.Abs(this.Rx) > this.nudRx.Value)
                    this.labelRx.ForeColor = Color.Red;
                else
                    this.labelRx.ForeColor = Color.Black;

                if (Math.Abs(this.Ry) > this.nudRy.Value)
                    this.labelRy.ForeColor = Color.Red;
                else
                    this.labelRy.ForeColor = Color.Black;

                if (Math.Abs(this.Rz) > this.nudRz.Value)
                    this.labelRz.ForeColor = Color.Red;
                else
                    this.labelRz.ForeColor = Color.Black;

            }
        }

        private void checkBoxLED_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLED.Checked)
                _device.LEDs = -1; //All LEDs on
            else
                _device.LEDs = 0; //All LEDs off
            log.Debug("Set LED to {0}", _device.LEDs);
        }

        internal virtual void OnDeviceMotion(_3DxMotionEventArgs args)
        {
            if (DeviceMotion != null)
                DeviceMotion(this, args);
        }
    }
}
