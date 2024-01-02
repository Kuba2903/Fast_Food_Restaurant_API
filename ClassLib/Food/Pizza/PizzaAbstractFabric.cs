using ClassLib.Burgers.Ingredients.Bacon;
using ClassLib.Burgers.Ingredients.Cheese;
using ClassLib.Burgers.Ingredients.Meat;
using ClassLib.Burgers.Ingredients.Onion;
using ClassLib.Burgers.Ingredients.Sauce;
using ClassLib.Food.Ingredients.Dough;
using ClassLib.Food.Ingredients.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Pizza
{
    public abstract class PizzaAbstractFabric
    {
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected int Calories { get; set; }
        protected IMeat CreateMeat()
        {
            var meat = new Salami();
            meat.GetMeat();
            return meat;
        }
        protected ICheese CreateCheese()
        {
            var cheese = new Mozarella();
            cheese.GetCheese();
            return cheese;
        }
        protected IBacon CreateBacon()
        {
            var bacon = new Bacon();
            bacon.GetBacon();
            return bacon;
        }
        protected abstract IDough CreateDough();
        protected abstract IOnion CreateOnion();
        protected abstract ISauce CreateSauce();
        public string GetName() => Name;
        public double GetPrice() => Price;
        public int GetCalories() => Calories;
        public abstract void IngredientsList();
    }
}
