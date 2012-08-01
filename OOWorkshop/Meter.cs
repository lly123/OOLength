using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Meter
    {
        private int number;

        public Meter(int number)
        {
            this.number = number;
        }

        public static Meter operator+(Meter m1, Meter m2)
        {
            return new Meter(m1.number + m2.number);
        }

        public override bool Equals(object obj)
        {
            var meter = obj as Meter;
            return meter.number == number;
        }

        public override int GetHashCode()
        {
            return number;
        }
    }
}
