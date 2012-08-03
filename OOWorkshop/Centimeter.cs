using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Centimeter
    {
        public Centimeter(double number)
        {
            Number = number;
        }

        protected double Number { get; private set; }

        public static Centimeter operator +(Centimeter cm1, Centimeter cm2)
        {
            return new Centimeter(cm1.Number + cm2.Number);
        }

        public static Centimeter operator +(Centimeter cm, Decimeter dm)
        {
            return new Centimeter(cm.Number + 10 * dm.Number);
        }

        public static Centimeter operator +(Centimeter cm, Meter m)
        {
            return new Centimeter(cm.Number + 100 * m.Number);
        }

        public override bool Equals(object obj)
        {
            var centimeter = obj as Centimeter;
            return centimeter.Number.Equals(Number);
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}