using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
   
    public abstract class Length
    {
        public double Number { get; protected set; }

        public abstract int Factor();

        public double ConvertToCM()
        {
            return Number * Factor();
        }
    }
}
