using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Cucumber
{
    public class NormalCucumber : ICucumber
    {
        public ICucumber GetCucumber()
        {
            Console.WriteLine("Green cucumber");
            return this;
        }
    }
}
