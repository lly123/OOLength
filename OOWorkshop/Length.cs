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

        public static Length operator +(Length length1, Length length2)
        {
            if (length1 is Centimeter)
            {
                return new Centimeter((length1.ConvertToCM() + length2.ConvertToCM()) / length1.Factor());                
            }

            if (length1 is Decimeter)
            {
                return new Decimeter((length1.ConvertToCM() + length2.ConvertToCM()) / length1.Factor());
            }

            if (length1 is Meter)
            {
                return new Meter((length1.ConvertToCM() + length2.ConvertToCM()) / length1.Factor());
            }

            throw new NotImplementedException();
        }
    }
}
