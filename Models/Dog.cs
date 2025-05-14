using net_core_symbols.Interfaces;

namespace net_core_symbols.Models
{
    public class Dog : IAnimal
    {
        public string Name { get; }
        private readonly ILogger _logger;

        public Dog(string name, ILogger logger)
        {
            Name = name;
            _logger = logger;
        }

        public void Speak()
        {
            _logger.Log($"{Name} says: Woof!");
        }
    }
}