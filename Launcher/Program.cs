using ClassLib;
using ClassLib.Burgers;
using ClassLib.Commands;
using ClassLib.ConcreteDrinks;
using ClassLib.Drinks.Decorators;
using ClassLib.Facade;
using ClassLib.Food.Pizza;
using ClassLib.Food.Sandwiches;

namespace Launcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            CreatingOrder facade = new CreatingOrder();
            AbstractDrinks drink = new Cola(Size.Small);
            SandwichAbstractFabric sandwich = new MeatSandwich();
            Waitress waitress = new Waitress(sandwich,drink);
            facade.CreateOrder(waitress);
        }
    }
}