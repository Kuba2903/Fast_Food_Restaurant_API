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
    public abstract class BurgerFabric
    {
        protected string Name { get; set; }
        protected double Price { get; set; }

        protected abstract IBun CreateBun();
        protected abstract ICucumber CreateCucumber();
        protected abstract ILettuce CreateLettuce();
        protected abstract IMeat CreateMeat();
        protected abstract IOnion CreateOnion();
        protected abstract ISauce CreateSauce();
        protected abstract ICheese CreateCheese();
        protected abstract IBacon CreateBacon();
        public abstract void IngredientsList();
        public abstract string GetName();
        public abstract double GetPrice();
    }
}
