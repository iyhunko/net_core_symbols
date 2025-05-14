using net_core_symbols.Interfaces;

namespace net_core_symbols.Services
{
    public class ChainHandler
    {
        private readonly AnimalService _service;

        public ChainHandler(AnimalService service)
        {
            _service = service;
        }

        public void ProcessAnimal(IAnimal animal)
        {
            _service.DescribeAnimal(animal);
            ExtraStep(animal);
        }

        private void ExtraStep(IAnimal animal)
        {
            Console.WriteLine($"{animal.Name} is now registered in the system.");
        }
    }
}