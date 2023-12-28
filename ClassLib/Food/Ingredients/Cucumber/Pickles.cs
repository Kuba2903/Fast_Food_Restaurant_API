using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Cucumber
{
    public class Pickles : ICucumber
    {
        public ICucumber GetCucumber()
        {
            Console.WriteLine("Pickles");
            return this;
        }
    }
}
