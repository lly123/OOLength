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

        public override int Factor()
        {
            return 1;
        }

        public override bool Equals(object obj)
        {
            if (obj is Meter)
            {
                var meter = obj as Meter;
                return Number.Equals(meter.Number*100);
            }

            if (obj is Centimeter)
            {
                var centimeter = obj as Centimeter;
                return Number.Equals(centimeter.Number);
            }
           
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}