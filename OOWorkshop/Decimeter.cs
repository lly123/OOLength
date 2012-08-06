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

        public override int Factor()
        {
            return 10;
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