using ClassLib.Burgers.Ingredients.Onion;
using ClassLib.Burgers.Ingredients.Sauce;
using ClassLib.ConcreteDrinks;
using ClassLib.Food.Ingredients.Dough;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Pizza
{
    public class BaconPizza : PizzaAbstractFabric
    {
        public BaconPizza(Size size)
        {
            Name = "Bacon pizza";
            switch (size)
            {
                case Size.Small:
                    Price = 27.99;
                    Calories = 1400;
                    break;
                case Size.Medium:
                    Price = 38.99;
                    Calories = 1800;
                    break;
                case Size.Large:
                    Price = 45.99;
                    Calories = 2200;
                    break;
            }
        }

        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n");
            CreateDough();
            CreateCheese();
            CreateBacon();
            CreateOnion();
            CreateSauce();
        }

        protected override IDough CreateDough()
        {
            var dough = new ThickDough();
            dough.GetDough();
            return dough;
        }

        protected override IOnion CreateOnion()
        {
            var onion = new WhiteOnion();
            onion.GetOnion();
            return onion;
        }

        protected override ISauce CreateSauce()
        {
            var ketchup = new KetchupSauce();
            ketchup.GetSauce();
            return ketchup;
        }
    }
}
