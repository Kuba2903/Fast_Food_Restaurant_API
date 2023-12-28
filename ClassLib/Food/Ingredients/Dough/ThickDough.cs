using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Ingredients.Dough
{
    public class ThickDough : IDough
    {
        public IDough GetDough()
        {
            Console.WriteLine("Thick dough");
            return this;
        }
    }
}
