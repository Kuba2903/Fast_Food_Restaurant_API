using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Bacon
{
    public class Bacon : IBacon
    {
        public IBacon GetBacon()
        {
            Console.WriteLine("Bacon");
            return this;
        }
    }
}
