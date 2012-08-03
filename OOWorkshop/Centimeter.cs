using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Centimeter : Length
    {
        public Centimeter(double number)
        {
            Number = number;
        }

        public static Centimeter operator +(Centimeter cm, Length length)
        {
            int factor = 1;

            if (length is Decimeter)
            {
                factor = 10;
            } 
            
            if (length is Meter)
            {
                factor = 100;
            }

            return new Centimeter(cm.Number + factor * length.Number);
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