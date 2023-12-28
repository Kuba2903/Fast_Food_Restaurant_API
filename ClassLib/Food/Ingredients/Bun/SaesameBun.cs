using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Bun
{
    public class SaesameBun : IBun
    {
        public IBun GetBun()
        {
            Console.WriteLine("Bun with saesame");
            return this;
        }
    }
}
