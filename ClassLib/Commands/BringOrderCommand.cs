using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Commands
{
    public class BringOrderCommand : ICommand
    {
        Waitress waitress;

        public BringOrderCommand(Waitress waitress)
        {
            this.waitress = waitress;
        }
        public void Do() => waitress.BringOrder();
    }
}
