using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo06
{
    class Robot : IDrive, IConquer
    {
        public string Name { get; set; }

        public string Start()
        {
            return "I am a robot starting a Car";
        }

        public void TakeOverWorld()
        {
            Console.WriteLine("Muwahahahhahaha");
        }
    }
}
