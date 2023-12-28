using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Burgers.Ingredients.Lettuce
{
    public class IcebergLettuce : ILettuce
    {
        public ILettuce GetLettuce()
        {
            Console.WriteLine("Iceberg lettuce");
            return this;
        }
    }
}
