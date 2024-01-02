using ClassLib.Burgers.Ingredients.Bacon;
using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Meat;
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
    public class SalamiPizza : PizzaAbstractFabric
    {
        public SalamiPizza(Size size)
        {
            Name = "Salami pizza";
            switch (size)
            {
                case Size.Small:
                    Price = 25;
                    Calories = 1200;
                    break;
                case Size.Medium:
                    Price = 35;
                    Calories = 1600;
                    break;
                case Size.Large:
                    Price = 42.99;
                    Calories = 2000;
                    break;
            }
        }

        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n" );
            CreateDough();
            CreateMeat();
            CreateCheese();
            CreateSauce();
        }

        protected override IDough CreateDough()
        {
            var dough = new ThinDough();
            dough.GetDough();
            return dough;
        }

        protected override ISauce CreateSauce()
        {
            var garlic = new GarlicSauce();
            garlic.GetSauce();
            return garlic;
        }

        protected override IOnion CreateOnion()
        {
            throw new NotImplementedException();
        }
    }
}
