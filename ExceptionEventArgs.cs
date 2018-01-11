using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumos3DconnexionPlugin
{
    class ExceptionEventArgs : EventArgs
    {
        public readonly Exception ExceptionObject;

        public ExceptionEventArgs(Exception e)
        {
            this.ExceptionObject = e;
        }
    }
}
