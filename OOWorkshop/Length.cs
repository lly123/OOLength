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
            var lengthNumberAccordingToLeftLengthUnit = (length1.ConvertToBaseUnit() + length2.ConvertToBaseUnit()) / length1.Factor();

            var rightLengthType = length1.GetType();
            var defaultConstructor = rightLengthType.GetConstructor(new []{ typeof(double) });
            return defaultConstructor.Invoke( new object[]{ lengthNumberAccordingToLeftLengthUnit }) as Length;
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
