namespace net_core_symbols
{
public class Coordinator
{
    private readonly Logger _logger;

    public Coordinator(Logger logger)
    {
        _logger = logger;
    }

    public void Run()
    {
        _logger.Log("Start");

        var dog = new Dog();
        var animalService = new AnimalService(dog);
        var dbService = new DatabaseService();

        var report = new ReportGenerator(animalService, dbService);
        report.Generate();

        _logger.Log("Done");
    }
}

public class Logger
{
    public void Log(string message) => Console.WriteLine("[Log] " + message);
}
}