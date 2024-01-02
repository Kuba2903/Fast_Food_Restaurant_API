using ClassLib.Burgers;
using ClassLib.Food.Pizza;
using ClassLib.Food.Sandwiches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Commands
{
    public class Waitress
    {
        public bool isFoodPrepared = false;
        public double OrderCost { get; set; }
        public List<string> OrderItems { get; set; }
        PizzaAbstractFabric pizza;
        BurgerAbstractFabric burger;
        SandwichAbstractFabric sandwich;
        AbstractDrinks drink;
        public Waitress(PizzaAbstractFabric pizza,AbstractDrinks drink)
        {
            this.pizza = pizza;
            this.drink = drink;
            OrderCost = pizza.GetPrice() + drink.GetPrice();
            OrderItems = new List<string>
            {
                pizza.GetName(),
                drink.GetName()
            };
        }

        public Waitress(BurgerAbstractFabric burger, AbstractDrinks drink)
        {
            this.burger = burger;
            this.drink = drink;
            OrderCost = burger.GetPrice() + drink.GetPrice();
            OrderItems = new List<string>
            {
                burger.GetName(),
                drink.GetName()
            };
        }

        public Waitress(SandwichAbstractFabric sandwich, AbstractDrinks drink)
        {
            this.sandwich = sandwich;
            this.drink = drink;
            OrderCost = sandwich.GetPrice() + drink.GetPrice();
            OrderItems = new List<string>
            {
                sandwich.GetName(),
                drink.GetName()
            };
        }

        public Waitress(AbstractDrinks drink)
        {
            this.drink = drink;
            OrderCost = drink.GetPrice();
            OrderItems = new List<string>
            {
                drink.GetName()
            };
        }

        public void MakeOrder()
        {
            isFoodPrepared = false;
            Console.WriteLine("The order is started to be prepared");
            Console.WriteLine("The final cost will be: " + OrderCost);
        }

        public void GetOrder()
        {
            isFoodPrepared = true;
            Console.WriteLine("Here is your order: ");
            Console.WriteLine("-----------------");
            foreach (var x in OrderItems)
            {
                Console.WriteLine($"{x}");
            }
            Console.WriteLine("-----------------");
        }
    }
}
