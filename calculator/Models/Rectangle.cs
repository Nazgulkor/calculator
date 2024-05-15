
using calculator.Interfaces;

namespace calculator.Models
{
    internal class Rectangle(double width, double height) : IShape
    {
        private const string figureName = "Прямоугольник";

        private double Width { get; set; } = width;
        private double Height { get; set; } = height;

        public string GetName()
        {
            return figureName;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
