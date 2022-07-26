using ILogger = JSONtoXMLDeserializer.API.Services.Abstract.ILogger;

namespace JSONtoXMLDeserializer.API.Services.Concrete {
    public class TxtLogger : ILogger {

        private readonly string _fileName = "convertLogs.txt";

        public void Log(string message) {
            var logMessage = $"[{DateTime.Now:s}]\t{message}";

            File.AppendAllLines(_fileName, new[] { logMessage });
        }
    }
}