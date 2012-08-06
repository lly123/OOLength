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
            if (obj is Centimeter)
            {
                var centimeter = obj as Centimeter;
                return Number.Equals(centimeter.Number / 10);
            }

            if (obj is Decimeter)
            {
                var decimeter = obj as Decimeter;
                return Number.Equals(decimeter.Number);
            }

            if (obj is Meter)
            {
                var meter = obj as Meter;
                return Number.Equals(meter.Number * 10);
            }

            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}