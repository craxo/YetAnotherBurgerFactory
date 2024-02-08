using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherBurgerFactory
{
    public class Burger
    {
        public Burger()
        {
            Toppings = new List<string>();
        }
        public string? Name { get; set; }
        public List<string> Toppings { get; set; }
        public bool IsCooked { get; private set; }

        internal void Cook()
        {
            IsCooked = true;
        }

        public string Print()
        {
            var toppings = string.Join(", ", Toppings);
            Name ??= "Burger";
            return $"{Name} with {toppings}";
        }
    }
}
