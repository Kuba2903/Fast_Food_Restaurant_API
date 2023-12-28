using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Onion
{
    public class WhiteOnion : IOnion
    {
        public IOnion GetOnion()
        {
            Console.WriteLine("White onion");
            return this;
        }
    }
}
