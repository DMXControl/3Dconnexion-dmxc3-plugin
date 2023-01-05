using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumosLIB.Kernel;
using LumosProtobuf;
using LumosProtobuf.Input;
using org.dmxc.lumos.Kernel.Input.v2;

namespace Lumos3DconnexionPlugin
{
    class _3DxInputSource : AbstractInputSource
    {
        private const string _ID = "{274CBFD7-8BE9-4636-8DD2-17EA001FA78C}";

        public _3DxInputSource(E3DxAchsis axis) : base(_ID + "-" + axis, axis.ToString(), ParameterCategoryTools.FromName(_3DxPlugin.PLUGIN_NAME), 90)
        {
            this.Axis = axis;
        }

        public E3DxAchsis Axis { get; }

        public override EWellKnownInputType AutoGraphIOType => EWellKnownInputType.Numeric;

        public override object Min => 0;

        public override object Max => 100;

        public void SetValue(int value)
        {
            this.CurrentValue = value;
        }
    }
}
