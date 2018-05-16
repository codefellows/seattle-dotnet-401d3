using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    class Supreme : Pizza
    {
        public Supreme()
        {
            Name = "Supreme";
            Sauce = "Red Sauce";
            Dough = "Stuffed Crust";
            Ingredients.Add("Pepperoni");
            Ingredients.Add("Peppers");
            Ingredients.Add("Onions");
            Ingredients.Add("Italian Sausage");
            Ingredients.Add("Olives");
            Ingredients.Add("Mushrooms");



        }
    }
}
