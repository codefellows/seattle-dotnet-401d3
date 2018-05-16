using System;
using FactoryDemoClass41.Classes;

namespace FactoryDemoClass41
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaPlanetStore();
            
           // Console.WriteLine("Hello World!");
        }

        static void PizzaPlanetStore()
        {
            PizzaPlanet pp = new PizzaPlanet();
            pp.OrderPizza("Galactic Pepperoni");

        }
    }
}
