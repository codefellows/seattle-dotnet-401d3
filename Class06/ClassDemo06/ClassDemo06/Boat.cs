using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo06
{
    class Boat
    {
        public void Drive(IDrive drive)
        {
            Console.WriteLine($"{drive.Name} is boating");

        }
    }
}
