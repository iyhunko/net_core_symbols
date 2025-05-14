using net_core_symbols;

namespace net_core_symbols
{
public class AnimalService
{
    private readonly IAnimal _animal;
    public AnimalService(IAnimal animal)
    {
        _animal = animal;
    }
    public string MakeSound()
    {
        return _animal.Speak();
    }

}
}