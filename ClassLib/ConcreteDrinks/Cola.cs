using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ConcreteDrinks
{
    public enum Size
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }
    public class Cola : AbstractDrinks
    {

        public Cola(Size size)
        {
            Name = "Cola";
            switch(size)
            {
                case Size.Small:
                    Calories = 100;
                    Price = 8;
                    Description = "Small coca cola";
                    break;
                case Size.Medium:
                    Calories = 200;
                    Price = 10;
                    Description = "Medium coca cola";
                    break;
                case Size.Large:
                    Calories = 300;
                    Price = 11.50;
                    Description = "Large coca cola";
                    break;
            }
            Additives = new List<string>();
        }

        public override List<string> GetAdditives() => Additives;

        public override int GetCalories() => Calories;

        public override string GetDescription() => Description;

        public override string GetName() => Name;

        public override double GetPrice() => Price;

        public override string ToString()
        {
            return $"Name: {GetName()}\n Description: {GetDescription()}\n Price: {GetPrice()}\n Calories: {GetCalories()}";
        }
    }
}
