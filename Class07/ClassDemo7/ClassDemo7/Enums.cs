using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo7
{
    class Enums
    {

    }

    enum Days
    {
        Sunday = 1,
        Monday = 15,
        Tuesday = 100,
        Wednesday = Tuesday + 10,
        Thursday = 100,
        Friday,
        Saturday
    };

    enum Months: byte
    {
        Jan,
        Feb,
        March,

    }
}
