using ClassLib.Burgers.Ingredients.Cheese;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Ingredients.Cheese
{
    public class Ementaler : ICheese
    {
        public ICheese GetCheese()
        {
            Console.WriteLine("Ementaler cheese");
            return this;
        }
    }
}
