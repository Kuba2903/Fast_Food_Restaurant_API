using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Onion
{
    public class RedOnion : IOnion
    {
        public IOnion GetOnion()
        {
            Console.WriteLine("Red onion");
            return this;
        }
    }
}
