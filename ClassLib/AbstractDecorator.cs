using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public abstract class AbstractDecorator : AbstractDrinks
    {
        AbstractDrinks drinks;

        public AbstractDecorator(AbstractDrinks drinks)
        {
            this.drinks = drinks;
        }

        public override string GetName() => drinks.GetName();
        public override string GetDescription() => drinks.GetDescription();
        public override int GetCalories() => drinks.GetCalories();
        public override double GetPrice() => drinks.GetPrice();
        public override List<string> GetAdditives() => drinks.GetAdditives();
        public override string ToString() => drinks.ToString();

    }
}
