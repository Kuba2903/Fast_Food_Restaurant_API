using ClassLib.Burgers;
using ClassLib.Food.Pizza;
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
        PizzaAbstractFabric pizza;
        BurgerAbstractFabric burger;
        AbstractDrinks drink;
        public Waitress(PizzaAbstractFabric pizza, AbstractDrinks drink)
        {
            this.pizza = pizza;
            this.drink = drink;
        }

        public Waitress(BurgerAbstractFabric burger, AbstractDrinks drink)
        {
            this.burger = burger;
            this.drink = drink;
        }

        public void GetOrder()
        {
            isFoodPrepared = false;
            Console.WriteLine("The order is started to be prepared");
            if(pizza != null)
                Console.WriteLine($"The final cost will be {pizza.GetPrice() + drink.GetPrice()}");
            else if(burger != null)
                Console.WriteLine($"The final cost will be {burger.GetPrice() + drink.GetPrice()}");
        }

        public void BringOrder()
        {
            isFoodPrepared = true;
            if(pizza != null)
                Console.WriteLine($"Here is your food {pizza.GetName()}, {drink.GetName()}");
            else if(burger != null)
                Console.WriteLine($"Here is your food {burger.GetName()}, {drink.GetName()}");
        }
    }
}
