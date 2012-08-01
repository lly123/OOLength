using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOWorkshop
{
    public class Meter
    {
        public Meter(double number)
        {
            this.Number = number;
        }

        public double Number { get; private set; }

        public static Meter operator+(Meter m1, Meter m2)
        {
            return new Meter(m1.Number + m2.Number);
        }

        public static Meter operator-(Meter m1, Meter m2)
        {
            if (m1.Number - m2.Number < 0) throw new NegativeValueException();
            return new Meter(m1.Number - m2.Number);
        }

        public override bool Equals(object obj)
        {
            var meter = obj is Decimeter ? 
                convertDecimeterToMeter(obj as Decimeter) : (obj as Meter);
            return meter.Number == Number;                
            
        }

        private Meter convertDecimeterToMeter(Decimeter decimeter)
        {
            return new Meter(decimeter.Number / 10);
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}
