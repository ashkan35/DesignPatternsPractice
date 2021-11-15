namespace Decorator
{
    public sealed class Hyundai:ICar
    {
        public string Make => "HatchBack";

        public double GetPrice()
        {
            return 80000;
        }
    }
}