using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Commands
{
    public class GetOrderCommand : ICommand
    {
        Waitress waitress;

        public GetOrderCommand(Waitress waitress)
        {
            this.waitress = waitress;
        }

        public void Do() => waitress.GetOrder();
    }
}
