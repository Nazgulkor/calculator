
namespace calculator.Interfaces
{
    public interface ILogger
    {
        public string LogSample { get; set; }
        public void WriteLog();
        public List<string> GetLogs();
    }
}
