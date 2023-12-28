using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Lettuce
{
    public class RomanLettuce : ILettuce
    {
        public ILettuce GetLettuce()
        {
            Console.WriteLine("Roman lettuce");
            return this;
        }
    }
}
