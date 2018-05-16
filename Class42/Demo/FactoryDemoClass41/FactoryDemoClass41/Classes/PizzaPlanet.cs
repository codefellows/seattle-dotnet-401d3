using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    class PizzaPlanet : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Console.WriteLine("Welcome to Pizza Planet!!");
            Console.WriteLine("Buzz Lightyear to the rescue!");

            return PizzaPlanetFactory.CreatePizza(type);

        }
    }
}
