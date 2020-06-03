using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using org.dmxc.lumos.Kernel.DeviceProperties;

namespace Lumos3DconnexionPlugin
{
    class _3DxMotionEventArgs : EventArgs
    {
        public readonly Dictionary<E3DxAchsis, int> AxisValues = new Dictionary<E3DxAchsis, int>();
    }
}
