using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public enum SugarSpoons
    {
        Half_Spoon = 0,
        One_Spoon = 1,
        One_HalfSpoon = 2,
        Two_Spoons = 3
    }
    public abstract class AbstractDrinks
    {
        protected double Price { get; set; }
        protected string Name { get; set; }
        protected string Description { get; set; }
        protected int Calories { get; set; }
        protected List<string> Additives { get; set; }
        protected SugarSpoons Spoons { get; set; }

        public abstract double GetPrice();
        public abstract string GetName();
        public abstract string GetDescription();
        public abstract int GetCalories();
        public abstract List<string> GetAdditives();
        public override abstract string ToString();
    }
}
