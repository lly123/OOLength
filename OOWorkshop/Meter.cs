﻿namespace OOWorkshop
{
    public class Meter : Length
    {
        public Meter(double number) : base(number, M_FACTOR)
        {
        }

        public static Meter operator -(Meter m1, Meter m2)
        {
            if (m1.Number - m2.Number < 0) throw new NegativeValueException();
            return new Meter(m1.Number - m2.Number);
        }
    }
}