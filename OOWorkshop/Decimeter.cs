using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    internal class Decimeter
    {
        private double number;

        public Decimeter(double number)
        {
            this.number = number;
        }

        public static Decimeter operator +(Decimeter dm1, Decimeter dm2)
        {
            return new Decimeter(dm1.number + dm2.number);
        }

        public static Decimeter operator +(Decimeter dm, Meter m)
        {
            return new Decimeter(dm.number + 10*m.Number);
        }

        public double Number
        {
            get { return number; }
        }

        public override bool Equals(object obj)
        {
            var decimeter = obj as Decimeter;
            return decimeter.number == number;
        }

        public override int GetHashCode()
        {
            return number.GetHashCode();
        }
    }
}