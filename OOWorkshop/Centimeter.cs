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
    }
}