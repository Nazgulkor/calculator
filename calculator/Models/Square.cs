using calculator.Interfaces;

namespace calculator.Models
{
    internal class Square(double side) : IShape
    {
        private const string figureName = "Квадрат";
        private double Side { get; set; } = side;

        public string GetName()
        {
            return figureName;
        }

        public double CalculatePerimeter()
        {
            return 4 * Side;
        }

        public double CalculateArea()
        {
            return Side * Side;
        }
    }
}
