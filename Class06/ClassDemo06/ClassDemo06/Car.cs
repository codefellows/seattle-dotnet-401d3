using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo06
{
    class Car
    {

        public string Name { get; set; }

        public void Drive(IDrive e)
        {
            Console.WriteLine($"{e.Name} is driving");
        }

        public void BuyCar(Person person)
        {
            Console.WriteLine("I am a person, and i am buying a car");
        }
    }
}
