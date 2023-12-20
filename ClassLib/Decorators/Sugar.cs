using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Decorators
{
    public class Sugar : AbstractDecorator
    {
        public Sugar(AbstractDrinks drinks, SugarSpoons spoons) : base(drinks)
        {
            Spoons = spoons;
        }


        public override string GetName()
        {
            return base.GetName();
        }

        public override string GetDescription()
        {
            var part = Spoons.ToString().Split('_');
            return base.GetDescription() + $"\n With {part[0].ToLower()} spoons of sugar";
        }

        public override List<string> GetAdditives()
        {
            var list = base.GetAdditives();
            list.Add("sugar");
            return list;
        }


        public override double GetPrice()
        {
            switch (Spoons)
            {
                case SugarSpoons.Half_Spoon:
                    {
                        return base.GetPrice() + 0.20;
                    }

                case SugarSpoons.One_Spoon:
                    {
                        return base.GetPrice() + 0.30;
                    }

                case SugarSpoons.One_HalfSpoon:
                    {
                        return base.GetPrice() + 0.40;
                    }

                case SugarSpoons.Two_Spoons:
                    {
                        return base.GetPrice() + 0.50;
                    }

                default:
                    {
                        return base.GetPrice();
                    }

            }
        }

        public override int GetCalories()
        {
            switch (Spoons)
            {
                case SugarSpoons.Half_Spoon:
                    {
                        return base.GetCalories() + 10;
                    }

                case SugarSpoons.One_Spoon:
                    {
                        return base.GetCalories() + 20;
                    }

                case SugarSpoons.One_HalfSpoon:
                    {
                        return base.GetCalories() + 30;
                    }

                case SugarSpoons.Two_Spoons:
                    {
                        return base.GetCalories() + 40;
                    }

                default:
                    {
                        return base.GetCalories();
                    }

            }

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
