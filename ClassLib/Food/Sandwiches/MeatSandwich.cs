using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Cucumber;
using ClassLib.Burgers.Ingredients.Lettuce;
using ClassLib.Burgers.Ingredients.Meat;
using ClassLib.Food.Ingredients.Cheese;
using ClassLib.Food.Ingredients.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Sandwiches
{
    public class MeatSandwich : SandwichAbstractFabric
    {

        public MeatSandwich()
        {
            Name = "Meat Sandwich";
            Price = 9.25;
            Calories = 150;
        }

        public override void IngredientsList()
        {
            Console.WriteLine("Ingredients list: \n");
            CreateCheese();
            CreateCucumber();
            CreateLettuce();
            CreateMeat();
            CreateBacon();
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
            var salami = new Salami();
            salami.GetMeat();
            return salami;
        }
    }
}
