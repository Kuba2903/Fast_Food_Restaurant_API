using ClassLib.Burgers.Ingredients.Bacon;
using ClassLib.Burgers.Ingredients.Bun;
using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Cucumber;
using ClassLib.Burgers.Ingredients.Lettuce;
using ClassLib.Burgers.Ingredients.Meat;
using ClassLib.Burgers.Ingredients.Onion;
using ClassLib.Burgers.Ingredients.Sauce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers
{
    public class VegeBurger : BurgerAbstractFabric
    {

        public VegeBurger()
        {
            Name = "Vege burger";
            Price = 12.50;
            Calories = 150;
        }

        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n");

            CreateBun();
            CreateMeat();
            CreateLettuce();
            CreateCucumber();
            CreateOnion();
            CreateSauce();
        }

        protected override IBun CreateBun()
        {
            var bun = new NormalBun();
            bun.GetBun();
            Console.WriteLine();
            return bun;
        }

        protected override ICucumber CreateCucumber()
        {
            var pickles = new Pickles();
            pickles.GetCucumber();
            Console.WriteLine();
            return pickles;
        }

        protected override ILettuce CreateLettuce()
        {
            var lettuce = new IcebergLettuce();
            lettuce.GetLettuce();
            Console.WriteLine();
            return lettuce;
        }

        protected override IMeat CreateMeat()
        {
            var meat = new VegeMeat();
            meat.GetMeat();
            Console.WriteLine();
            return meat;
        }

        protected override IOnion CreateOnion()
        {
            var onion = new WhiteOnion();
            onion.GetOnion();
            Console.WriteLine();
            return onion;
        }

        protected override ISauce CreateSauce()
        {
            var sauce = new GarlicSauce();
            sauce.GetSauce();
            Console.WriteLine();
            return sauce;
        }
    }
}
