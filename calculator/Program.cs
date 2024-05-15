using calculator.Models;
using calculator.Interfaces;
using calculator.Logging;

namespace calculator
{
    internal class Program
    {
        static void Main()
        {
            IShape square = new Square(7);
            IShape circle = new Circle(10);
            IShape rectangle = new Rectangle(12, 10);

            ILogger FileLogger = new FileLogger();

            Calculator calc = new(FileLogger);

            calc.GetArea(square);
            calc.GetArea(circle);
            calc.GetPerimeter(rectangle);

            List<string> lines = FileLogger.GetLogs();
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}
