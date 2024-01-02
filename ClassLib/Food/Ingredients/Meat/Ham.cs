using ClassLib.Burgers.Ingredients.Meat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Food.Ingredients.Meat
{
    public class Ham : IMeat
    {
        public IMeat GetMeat()
        {
            Console.WriteLine("Ham");
            return this;
        }
    }
}
