using net_core_symbols.Interfaces;
using net_core_symbols.Models;
using net_core_symbols.Services;
using net_core_symbols.Utils;

class Program
{
    static void Main(string[] args)
    {
        ILogger logger = new ConsoleLogger();
        IAnimal dog = new Dog("Rex", logger);
        IAnimal cat = new Cat("Murka", logger);

        AnimalService service = new AnimalService(logger);
        ChainHandler handler = new ChainHandler(service);

        handler.ProcessAnimal(dog);
        handler.ProcessAnimal(cat);

        Helper.PrintDivider();
    }
}