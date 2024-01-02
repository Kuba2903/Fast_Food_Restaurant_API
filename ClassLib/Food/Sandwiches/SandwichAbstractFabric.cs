using ClassLib.Burgers.Ingredients.Bacon;
using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Cucumber;
using ClassLib.Burgers.Ingredients.Lettuce;
using ClassLib.Burgers.Ingredients.Meat;
using ClassLib.Burgers.Ingredients.Onion;
using ClassLib.Food.Ingredients.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Sandwiches
{
    public abstract class SandwichAbstractFabric
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected int Calories { get; set; }
        protected abstract IMeat CreateMeat();
        protected abstract ICheese CreateCheese();
        protected virtual IOnion CreateOnion() => new RedOnion();
        protected abstract ICucumber CreateCucumber();
        protected abstract ILettuce CreateLettuce();
        protected IBacon CreateBacon()
        {
            var bacon = new Bacon();
            bacon.GetBacon();
            return bacon;
        }

        public string GetName() => Name;
        public double GetPrice() => Price;
        public int GetCalories() => Calories;
        public abstract void IngredientsList();
    }
}
