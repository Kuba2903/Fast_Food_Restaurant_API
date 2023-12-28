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
    public class CheeseBurger : BurgerFabric
    {

        public CheeseBurger()
        {
            Name = "Cheese burger";
            Price = 11;
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
            CreateCheese();
        }

        protected override IBun CreateBun()
        {
            var bun = new SaesameBun();
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

        protected override IOnion CreateOnion()
        {
            var onion = new RedOnion();
            onion.GetOnion();
            Console.WriteLine();
            return onion;
        }

        protected override ISauce CreateSauce()
        {
            var sauce = new KetchupSauce();
            sauce.GetSauce();
            Console.WriteLine();
            return sauce;
        }

        protected override ICheese CreateCheese()
        {
            var cheese = new Mozarella();
            cheese.GetCheese();
            Console.WriteLine();
            return cheese;
        }

        protected override IBacon CreateBacon()
        {
            throw new NotImplementedException();
        }

        public override string GetName() => Name;

        public override double GetPrice() => Price;
    }
}
