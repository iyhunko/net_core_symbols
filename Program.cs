using net_core_symbols;

namespace net_core_symbols
{
class Program
{
    static void Main(string[] args)
    {
        var logger = new Logger();
        var coordinator = new Coordinator(logger);
        coordinator.Run();
    }
}
}