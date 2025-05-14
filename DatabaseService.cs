using net_core_symbols;

namespace net_core_symbols
{
public class DatabaseService : IDatabase
{
    public void Save(string data)
    {
        Console.WriteLine("Saved: " + data);
    }
}
}