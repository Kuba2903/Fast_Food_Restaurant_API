using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Cheese
{
    public class Mozarella : ICheese
    {
        public ICheese GetCheese()
        {
            Console.WriteLine("Mozarella cheese");
            return this;
        }
    }
}
