using net_core_symbols.Interfaces;

namespace net_core_symbols.Services
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("[LOG]: " + message);
        }
    }
}
