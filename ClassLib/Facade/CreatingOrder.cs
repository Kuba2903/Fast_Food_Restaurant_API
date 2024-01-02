using ClassLib.Burgers;
using ClassLib.Commands;
using ClassLib.ConcreteDrinks;
using ClassLib.Food.Pizza;
using ClassLib.Food.Sandwiches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Facade
{
    public class CreatingOrder
    {
        private Dictionary<string,double> Pizza;
        private Dictionary<string, double> Burgers;
        private Dictionary<string, double> Sandwiches;
        private Dictionary<string, double> Drinks;
        public CreatingOrder()
        {
            Pizza = new Dictionary<string, double>();
            Burgers = new Dictionary<string, double>();
            Sandwiches = new Dictionary<string, double>();
            Drinks = new Dictionary<string, double>();
            PizzaAbstractFabric bacon = new BaconPizza(ConcreteDrinks.Size.Medium);
            PizzaAbstractFabric salami = new SalamiPizza(ConcreteDrinks.Size.Medium);
            BurgerAbstractFabric baconBurger = new BaconBurger();
            BurgerAbstractFabric cheeseBurger = new CheeseBurger();
            BurgerAbstractFabric vegeBurger = new VegeBurger();
            SandwichAbstractFabric hamSandwich = new HamSandwich();
            SandwichAbstractFabric meatSandwich = new MeatSandwich();
            SandwichAbstractFabric vegeSandwich = new VegeSandwich();
            AbstractDrinks coffee = new Coffee();
            AbstractDrinks tea = new Tea();
            AbstractDrinks fanta = new Fanta(Size.Medium);
            AbstractDrinks cola = new Cola(Size.Medium);


            Pizza.Add(bacon.GetName(),bacon.GetPrice());
            Pizza.Add(salami.GetName(), salami.GetPrice());
            Burgers.Add(baconBurger.GetName(), baconBurger.GetPrice());
            Burgers.Add(cheeseBurger.GetName(), cheeseBurger.GetPrice());
            Burgers.Add(vegeBurger.GetName(), vegeBurger.GetPrice());
            Sandwiches.Add(hamSandwich.GetName(), hamSandwich.GetPrice());
            Sandwiches.Add(meatSandwich.GetName(), meatSandwich.GetPrice());
            Sandwiches.Add(vegeSandwich.GetName(), vegeSandwich.GetPrice());
            Drinks.Add(coffee.GetName(), coffee.GetPrice());
            Drinks.Add(tea.GetName(), tea.GetPrice());
            Drinks.Add(fanta.GetName(), fanta.GetPrice());
            Drinks.Add(cola.GetName(), cola.GetPrice());
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Pizza");
            Console.WriteLine("-------------------------------");
            foreach (var x in Pizza)
            {
                Console.WriteLine($"Name: {x.Key} Price: {x.Value}");
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Burgers");
            Console.WriteLine("-------------------------------");
            foreach (var x in Burgers)
            {
                Console.WriteLine($"Name: {x.Key} Price: {x.Value}");
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Sandwiches");
            Console.WriteLine("-------------------------------");
            foreach(var x in Sandwiches)
            {
                Console.WriteLine($"Name: {x.Key} Price: {x.Value}");
            }
            Console.WriteLine("-------------------------------");

            Console.WriteLine("Drinks");
            Console.WriteLine("-------------------------------");
            foreach (var x in Drinks)
            {
                Console.WriteLine($"Name: {x.Key} Price: {x.Value}");
            }
            Console.WriteLine("-------------------------------");
        }

        public void CreateOrder(Waitress waitress)
        {
            Pilot pilot = new Pilot();
            ICommand _command = new MakeOrderCommand(waitress);
            pilot.SetCommand(_command);
            pilot.ExecuteCommand();

            Console.WriteLine();
            Thread.Sleep(3000);
            GetOrder(waitress);
        }

        private void GetOrder(Waitress waitress)
        {
            Pilot pilot = new Pilot();
            ICommand _command = new BringOrderCommand(waitress);
            pilot.SetCommand(_command);
            pilot.ExecuteCommand();
        }
    }
}
