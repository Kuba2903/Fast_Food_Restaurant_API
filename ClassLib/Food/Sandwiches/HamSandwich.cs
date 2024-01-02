using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Cucumber;
using ClassLib.Burgers.Ingredients.Lettuce;
using ClassLib.Burgers.Ingredients.Meat;
using ClassLib.Burgers.Ingredients.Onion;
using ClassLib.Food.Ingredients.Cheese;
using ClassLib.Food.Ingredients.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Sandwiches
{
    public class HamSandwich : SandwichAbstractFabric
    {

        public HamSandwich()
        {
            Name = "Ham Sandwich";
            Price = 7.50;
            Calories = 120;
        }
        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n");
            CreateCheese();
            CreateCucumber();
            CreateMeat();
            CreateLettuce();
        }

        protected override ICheese CreateCheese()
        {
            var cheese = new Gouda();
            cheese.GetCheese();
            return cheese;
        }

        protected override ICucumber CreateCucumber()
        {
            var cucumber = new NormalCucumber();
            cucumber.GetCucumber();
            return cucumber;
        }

        protected override ILettuce CreateLettuce()
        {
            var lettuce = new RomanLettuce();
            lettuce.GetLettuce();
            return lettuce;
        }

        protected override IMeat CreateMeat()
        {
            var ham = new Ham();
            ham.GetMeat();
            return ham;
        }
    }
}
