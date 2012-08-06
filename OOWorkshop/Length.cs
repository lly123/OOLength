using System;

namespace OOWorkshop
{
   
    public abstract class Length
    {
        public double Number { get; protected set; }

        public abstract int Factor();

        private double ConvertToBaseUnit()
        {
            return Number * Factor();
        }

        public static Length operator +(Length length1, Length length2)
        {
            if (length1 is Centimeter)
            {
                return new Centimeter((length1.ConvertToBaseUnit() + length2.ConvertToBaseUnit()) / length1.Factor());                
            }

            if (length1 is Decimeter)
            {
                return new Decimeter((length1.ConvertToBaseUnit() + length2.ConvertToBaseUnit()) / length1.Factor());
            }

            if (length1 is Meter)
            {
                return new Meter((length1.ConvertToBaseUnit() + length2.ConvertToBaseUnit()) / length1.Factor());
            }

            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj)) return true;

            if (obj is Length)
            {
                var length = obj as Length;
                var currentLengthToCm = Math.Floor(ConvertToBaseUnit());
                var otherLengthToCm = Math.Floor(length.ConvertToBaseUnit());
                return currentLengthToCm.Equals(otherLengthToCm);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Number.GetHashCode();
        }
    }
}
