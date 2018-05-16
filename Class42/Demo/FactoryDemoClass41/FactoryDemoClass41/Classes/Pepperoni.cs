using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    class Pepperoni : Pizza
    {
        public Pepperoni()
        {
            Name = "Pepperoni";
            Sauce = "Red Sauce";
            Dough = "Gluten-Free";
            Ingredients.Add("Pepperoni");
        }
    }
}
