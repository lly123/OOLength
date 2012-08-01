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

        public Meter Plus(Meter oneMeter)
        {
            return new Meter(1);
        }

        public override bool Equals(object obj)
        {
            var meter = obj as Meter;
            return meter.number == number;
        }


    }
}
