using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lumos3DconnexionPlugin
{
    class IncrementSupport
    {
        private int _increment = 0;

        private readonly int _triggerBoarder;
        private int lastValue;

        public IncrementSupport(int triggerBoarder)
        {
            _triggerBoarder = triggerBoarder;
        }

        public bool ResetOnDirectionChange
        {
            get;
            set;
        }

        public bool Increment(int value)
        {
            if (ResetOnDirectionChange)
            {
                if (Math.Sign(value) != Math.Sign(lastValue))
                    Reset();
                lastValue = value;
            }

            _increment += value;
            if (Math.Abs(_increment) > _triggerBoarder)
            {
                Reset();
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _increment = 0;
        }
    }
}
