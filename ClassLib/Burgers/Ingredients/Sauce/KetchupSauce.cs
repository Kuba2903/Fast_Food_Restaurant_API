using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Sauce
{
    public class KetchupSauce : ISauce
    {
        public ISauce GetSauce()
        {
            Console.WriteLine("Ketchup");
            return this;
        }
    }
}
