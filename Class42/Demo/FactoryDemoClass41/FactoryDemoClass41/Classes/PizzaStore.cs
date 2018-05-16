using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDemoClass41.Classes
{
    public abstract class PizzaStore
    {
        //private SimplePizzaFactory factory;

        //public PizzaStore(SimplePizzaFactory pizzaFactory)
        //{
        //    factory = pizzaFactory;
        //}

        //Factory
        protected abstract Pizza CreatePizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;

        }
    }
}
