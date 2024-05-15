using calculator.Interfaces;


namespace calculator
{
    public class Calculator()
    {
        private readonly ILogger? logger;

        public Calculator(ILogger? logger) : this()
        {
            this.logger = logger ?? null;
        }

        public double GetPerimeter(IShape shape)
        {
            double result = shape.CalculatePerimeter();

            WriteLog(shape.GetName(), "периметр");

            return result;
        }

        public double GetArea(IShape shape)
        {
            double result = shape.CalculateArea();

            WriteLog(shape.GetName(), "площадь");

            return result;
        }

        private void WriteLog(string figureName, string operation)
        {
            if (logger != null)
            {
                logger.LogSample = "Фигура: " + figureName + ". Калькуляция: " + operation + ". Время: " + DateTime.Now;
                logger.WriteLog();
            }
        }
    }
}
