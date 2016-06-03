using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.dmxc.lumos.Kernel.DeviceProperties;

namespace Lumos3DconnexionPlugin
{
    class _3DxMotionEventArgs : EventArgs
    {
        public readonly Dictionary<EPropertyType, int> AxisValues = new Dictionary<EPropertyType, int>();
    }
}
