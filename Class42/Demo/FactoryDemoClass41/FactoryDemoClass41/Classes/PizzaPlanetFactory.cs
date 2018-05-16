using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    class PizzaPlanetFactory
    {
        public static Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Over The Moon Pizza":
                    pizza = new Cheese();
                    break;
                case "Galactic Pepperoni":
                    pizza = new Pepperoni();
                    break;
                case "Zorg":
                    pizza = new Supreme();
                    break;
                default:
                    break;

            }

            return pizza;
        }
    }
}
