using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Meter
    {
        private double number;

        public Meter(double number)
        {
            this.number = number;
        }

        public double Number
        {
            get { return number; }
        }

        public static Meter operator+(Meter m1, Meter m2)
        {
            return new Meter(m1.number + m2.number);
        }

        public static Meter operator-(Meter m1, Meter m2)
        {
            if (m1.number - m2.number < 0) throw new NegativeValueException();
            return new Meter(m1.number - m2.number);
        }

        public override bool Equals(object obj)
        {
            if (obj is Meter)
            {
                var meter = obj as Meter;
                return meter.number == number;                
            }

            var decimeter = obj as Decimeter;
            return decimeter.Number == number * 10;
        }

        public override int GetHashCode()
        {
            return number.GetHashCode();
        }
    }
}
