using net_core_symbols.Interfaces;

namespace net_core_symbols.Models
{
    public class Cat : IAnimal
    {
        public string Name { get; }
        private readonly ILogger _logger;

        public Cat(string name, ILogger logger)
        {
            Name = name;
            _logger = logger;
        }

        public void Speak()
        {
            _logger.Log($"{Name} says: Meow!");
        }
    }
}