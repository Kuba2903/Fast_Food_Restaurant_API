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
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLib.Burgers
{
    public class BaconBurger : BurgerFabric
    {

        public BaconBurger()
        {
            Name = "Bacon burger";
            Price = 15.90;
        }

        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n");

            CreateBun();
            CreateMeat();
            CreateLettuce();
            CreateCucumber();
            CreateSauce();
            CreateBacon();
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
            var pickles = new NormalCucumber();
            pickles.GetCucumber();
            Console.WriteLine();
            return pickles;
        }

        protected override ILettuce CreateLettuce()
        {
            var lettuce = new RomanLettuce();
            lettuce.GetLettuce();
            Console.WriteLine();
            return lettuce;
        }

        protected override IMeat CreateMeat()
        {
            var meat = new BeefMeat();
            meat.GetMeat();
            Console.WriteLine();
            return meat;
        }



        protected override ISauce CreateSauce()
        {
            var sauce = new KetchupSauce();
            sauce.GetSauce();
            Console.WriteLine();
            return sauce;
        }



        protected override IBacon CreateBacon()
        {
            var bacon = new Bacon();
            bacon.GetBacon();
            Console.WriteLine();
            return bacon;
        }

        protected override IOnion CreateOnion()
        {
            throw new NotImplementedException();
        }

        protected override ICheese CreateCheese()
        {
            throw new NotImplementedException();
        }
        public override string GetName() => Name;

        public override double GetPrice() => Price;
    }
}
