using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Decimeter : Length
    {
        public Decimeter(double number)
        {
            Number = number;
        }

        public static Decimeter operator +(Decimeter dm, Length length)
        {
            int factor = 1;

            if (length is Meter)
            {
                factor = 10;
            }

            return new Decimeter(dm.Number + factor * length.Number);
        }

        public override bool Equals(object obj)
        {
            var decimeter = obj as Decimeter;
            return decimeter.Number.Equals(Number);
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}