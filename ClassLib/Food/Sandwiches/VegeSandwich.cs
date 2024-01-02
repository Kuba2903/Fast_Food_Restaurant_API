using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Cucumber;
using ClassLib.Burgers.Ingredients.Lettuce;
using ClassLib.Burgers.Ingredients.Meat;
using ClassLib.Food.Ingredients.Cheese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Sandwiches
{
    public class VegeSandwich : SandwichAbstractFabric
    {

        public VegeSandwich()
        {
            Name = "Vege Sandwich";
            Price = 6.99;
            Calories = 80;
        }
        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n");
            CreateCheese();
            CreateCucumber();
            CreateOnion();
            CreateLettuce();
        }

        protected override ICheese CreateCheese()
        {
            var cheese = new Ementaler();
            cheese.GetCheese();
            return cheese;
        }

        protected override ICucumber CreateCucumber()
        {
            var cucumber = new Pickles();
            cucumber.GetCucumber();
            return cucumber;
        }

        protected override ILettuce CreateLettuce()
        {
            var lettuce = new IcebergLettuce();
            lettuce.GetLettuce();
            return lettuce;
        }

        protected override IMeat CreateMeat()
        {
            throw new NotImplementedException();
        }
    }
}
