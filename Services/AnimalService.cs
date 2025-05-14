using net_core_symbols.Interfaces;

namespace net_core_symbols.Services
{
    public class AnimalService
    {
        private readonly ILogger _logger;

        public AnimalService(ILogger logger)
        {
            _logger = logger;
        }

        public void DescribeAnimal(IAnimal animal)
        {
            _logger.Log($"Animal name: {animal.Name}");
            animal.Speak();
        }
    }
}