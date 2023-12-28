﻿using ClassLib;
using ClassLib.Burgers;
using ClassLib.ConcreteDrinks;
using ClassLib.Drinks.Decorators;

namespace Launcher
{
    public class Program
    {
        static void Main(string[] args)
        {
            AbstractDrinks tea = new Lemon(new Sugar(new Tea(),SugarSpoons.Two_Spoons));
            AbstractDrinks coffee = new Cream(new Coffee());
            AbstractDrinks cola = new Cola(Size.Small);
            Console.WriteLine(cola.ToString());
            Console.WriteLine();
            Console.WriteLine(coffee.ToString());

            CheeseBurger burger = new CheeseBurger();
            burger.IngredientsList();
        }
    }
}