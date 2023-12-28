using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Sauce
{
    public class GarlicSauce : ISauce
    {
        public ISauce GetSauce()
        {
            Console.WriteLine("Garlic sauce");
            return this;
        }
    }
}
