using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        public string Dough { get; set; }
        public string Sauce { get; set; }
        public List<string> Ingredients = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Pizza is being prepared");

            foreach (string topping in Ingredients)
            {
                Console.WriteLine(topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Pizza is baking");
        }

        public void Cut()
        {
            Console.WriteLine("Pizza is being cut ");

        }

        public void Box()
        {
            Console.WriteLine("Pizza is boxed ");

        }

    }
}
