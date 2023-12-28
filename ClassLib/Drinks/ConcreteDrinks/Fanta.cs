using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.ConcreteDrinks
{
    public class Fanta : AbstractDrinks
    {

        public Fanta(Size size)
        {
            Name = "Fanta";
            switch (size)
            {
                case Size.Small:
                    Calories = 150;
                    Price = 8.50;
                    Description = "Small fanta";
                    break;
                case Size.Medium:
                    Calories = 250;
                    Price = 10.50;
                    Description = "Medium fanta";
                    break;
                case Size.Large:
                    Calories = 350;
                    Price = 12.50;
                    Description = "Large fanta";
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
