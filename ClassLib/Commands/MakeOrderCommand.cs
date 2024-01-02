﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Commands
{
    public class MakeOrderCommand : ICommand
    {
        Waitress waitress;

        public MakeOrderCommand(Waitress waitress)
        {
            this.waitress = waitress;
        }

        public void Do() => waitress.MakeOrder();
    }
}