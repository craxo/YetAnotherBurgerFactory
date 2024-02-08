using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YetAnotherBurgerFactory
{
    public static class BurgerFactory
    {
        public static Burger CreateBurger(string? name)
        {
            return new Burger
            {
                Name = name,
                Toppings = new List<string>()
            };
        }

        public static Burger AddBun(this Burger burger)
        {
            burger.Toppings.Add("Bun");
            return burger;
        }
            
        public static Burger AddTomato(this Burger burger)
        {
            burger.Toppings.Add("Tomato");
            return burger;
        }

        public static Burger AddLettuce(this Burger burger)
        {
            burger.Toppings.Add("Lettuce");
            return burger;
        }

        public static Burger AddCheese(this Burger burger)
        {
            burger.Toppings.Add("Cheese");
            return burger;
        }

        public static Burger AddOnion(this Burger burger)
        {
            burger.Toppings.Add("Onion");
            return burger;
        }

        public static Burger AddPaddy(this Burger burger)
        {
            burger.Toppings.Add("Paddy");
            return burger;
        }

        public static Burger AddMushroom(this Burger burger)
        {
            burger.Toppings.Add("Mushroom");
            return burger;
        }

        public static Burger Cook(this Burger burger)
        {
            burger.Cook();
            return burger;
        }
    }
}
