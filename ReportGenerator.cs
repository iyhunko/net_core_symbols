using net_core_symbols;

namespace net_core_symbols
{
public class ReportGenerator
{
    private readonly AnimalService _animalService;
    private readonly IDatabase _database;

    public ReportGenerator(AnimalService animalService, IDatabase database)
    {
        _animalService = animalService;
        _database = database;
    }

    public void Generate()
    {
        var sound = _animalService.MakeSound();
        var prepared = Utility.Prepare(sound);
        _database.Save(prepared);
    }
}
}