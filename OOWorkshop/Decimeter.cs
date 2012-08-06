namespace OOWorkshop
{
    public class Decimeter : Length
    {
        public Decimeter(double number)
        {
            Number = number;
        }

        public override int Factor()
        {
            return 10;
        }
    }
}