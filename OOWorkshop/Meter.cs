using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Meter : Length
    {
        public Meter(double number)
        {
            Number = number;
        }

        public override int Factor()
        {
            return 100;
        }

        public static Meter operator +(Meter m1, Meter m2)
        {
            return new Meter(m1.Number + m2.Number);
        }

        public static Meter operator -(Meter m1, Meter m2)
        {
            if (m1.Number - m2.Number < 0) throw new NegativeValueException();
            return new Meter(m1.Number - m2.Number);
        }

        public override bool Equals(object obj)
        {
            var meter = ConvertToMeter(obj);
            return meter.Number.Equals(Number);
        }

        private Meter ConvertToMeter(object obj)
        {
            if (obj is Decimeter) return ConvertDecimeterToMeter(obj as Decimeter);
            return (obj as Meter);
        }

        private Meter ConvertDecimeterToMeter(Decimeter decimeter)
        {
            return new Meter(decimeter.Number/10);
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}