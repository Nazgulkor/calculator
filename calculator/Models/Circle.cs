using calculator.Interfaces;

namespace calculator.Models
{
    internal class Circle(double radius) : IShape
    {
        private const string figureName = "Круг";
        private double Radius { get; set; } = radius;

        public string GetName()
        {
            return figureName;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

    }
}
