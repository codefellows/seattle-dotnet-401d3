using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            switch (type)
            {
                case "Cheese":
                    pizza = new Cheese();
                    break;
                case "Pepperoni":
                    pizza = new Pepperoni();
                    break;
                case "Supreme":
                    pizza = new Supreme();
                    break;
                    default:
                        break;
                    
            }

            return pizza;
        }
    }
}
