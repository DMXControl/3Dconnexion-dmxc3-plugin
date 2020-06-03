using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumosLIB.Kernel;
using org.dmxc.lumos.Kernel.Input.v2;

namespace Lumos3DconnexionPlugin
{
    class _3DxInputSource : AbstractInputSource
    {
        private const string ID = "{274CBFD7-8BE9-4636-8DD2-17EA001FA78C}";

        public _3DxInputSource(E3DxAchsis axis) : base(ID + "-" + axis, axis.ToString(), new ParameterCategory(_3DxPlugin.PLUGIN_NAME))
        {
            this.Axis = axis;
        }

        public E3DxAchsis Axis { get; }

        public override EWellKnownInputType AutoGraphIOType => EWellKnownInputType.NUMERIC;

        public override object Min => 0;

        public override object Max => 100;

        public void SetValue(int value)
        {
            this.CurrentValue = value;
        }
    }
}
