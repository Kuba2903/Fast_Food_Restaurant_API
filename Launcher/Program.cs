using ClassLib;
using ClassLib.Burgers;
using ClassLib.Commands;
using ClassLib.ConcreteDrinks;
using ClassLib.Drinks.Decorators;
using ClassLib.Food.Pizza;

namespace Launcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            SalamiPizza pizza = new SalamiPizza(Size.Medium);
            AbstractDrinks cola = new Cola(Size.Large);

            Waitress waitress = new Waitress(pizza,cola);
            ICommand bring = new BringOrderCommand(waitress);
            ICommand get = new GetOrderCommand(waitress);
            Pilot pilot = new Pilot();
            pilot.SetCommand(get);
            pilot.ExecuteCommand();
            pilot.SetCommand(bring);
            pilot.ExecuteCommand();
            
        }
    }
}