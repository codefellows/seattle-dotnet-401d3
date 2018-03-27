using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo06
{
    class Employee : Person, IDrive
    {
      public int BadgeID { get; set; }
        public string Name { get; set; }

        public string Start()
        {
            return "I started the Car";
        }
    }
}
