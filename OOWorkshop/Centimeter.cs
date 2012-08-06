namespace OOWorkshop
{
    public class Centimeter : Length
    {
        public Centimeter(double number) : base(number)
        {
        }

        public override int Factor()
        {
            return 1;
        }
    }
}