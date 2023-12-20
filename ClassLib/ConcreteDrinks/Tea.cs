using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ConcreteDrinks
{
    public class Tea : AbstractDrinks
    {
        public Tea()
        {
            Name = "Tea";
            Description = "Regular Tea";
            Price = 5;
            Calories = 2;
            Additives = new List<string>();
        }
        public override List<string> GetAdditives() => Additives;

        public override int GetCalories() => Calories;

        public override string GetDescription() => Description;

        public override string GetName() => Name;

        public override double GetPrice() => Price;

        public override string ToString()
        {
            string additivies = "";
            foreach (var item in Additives)
            {
                additivies += item.ToString() + ",";
            }

            return $"Name: {Name}\nDescription: {Description}\nPrice: {Price}\nCalories: {Calories} \n" +
                $"Additives: {additivies}";
        }
    }
}
