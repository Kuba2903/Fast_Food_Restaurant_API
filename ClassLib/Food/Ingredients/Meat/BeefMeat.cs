using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Meat
{
    public class BeefMeat : IMeat
    {
        public IMeat GetMeat()
        {
            Console.WriteLine("Beef meat");
            return this;
        }
    }
}
