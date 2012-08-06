namespace OOWorkshop
{
    public class Decimeter : Length
    {
        public Decimeter(double number) : base(number)
        {
        }

        public override int Factor()
        {
            return 10;
        }
    }
}