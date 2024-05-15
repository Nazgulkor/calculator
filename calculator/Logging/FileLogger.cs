using calculator.Interfaces;


namespace calculator.Logging
{
    class FileLogger() : ILogger
    {

        public string LogSample { get; set; } = "";

        const string filePath = "/storage/logs/logs.txt";

        public void WriteLog()
        {

            string directoryPath = Path.GetDirectoryName(filePath);

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using StreamWriter writer = new StreamWriter(filePath, append: true);
            writer.WriteLine(LogSample);
        }

        public List<string> GetLogs()
        {
            List<string> logs = new List<string>();

            if (File.Exists(filePath))
            {
                foreach (string line in File.ReadLines(filePath))
                {
                    logs.Add(line);
                }
            }
            return logs;
        }
    }
}
