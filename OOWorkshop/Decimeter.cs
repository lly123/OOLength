using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Decimeter
    {
        public double Number { get; private set; }

        public Decimeter(double number)
        {
            this.Number = number;
        }

        public static Decimeter operator +(Decimeter dm1, Decimeter dm2)
        {
            return new Decimeter(dm1.Number + dm2.Number);
        }

        public static Decimeter operator +(Decimeter dm, Meter m)
        {
            return new Decimeter(dm.Number + 10 * m.Number);
        }

        public override bool Equals(object obj)
        {
            var decimeter = obj as Decimeter;
            return decimeter.Number == Number;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}