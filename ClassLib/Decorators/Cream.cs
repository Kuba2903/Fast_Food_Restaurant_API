using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Decorators
{
    public class Cream : AbstractDecorator
    {
        public Cream(AbstractDrinks drinks) : base(drinks)
        {
        }

        public override List<string> GetAdditives()
        {
            var list = base.GetAdditives();
            list.Add("Cream");
            return list;
        }

        public override int GetCalories()
        {
            return base.GetCalories() + 20;
        }

        public override double GetPrice()
        {
            return base.GetPrice() + 0.50;
        }

        public override string GetDescription()
        {
            return base.GetDescription() + "\n with cream";
        }

        public override string ToString()
        {
            string additivies = "";
            foreach (var item in GetAdditives())
            {
                additivies += item.ToString() + ",";
            }
            additivies = additivies.Remove(additivies.LastIndexOf(","));

            return $"Name: {GetName()}\nDescription: {GetDescription()}\nPrice: {GetPrice()}\nCalories: {GetCalories()}\n" +
                $"Additives: {additivies}";
        }
    }
}
