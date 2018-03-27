using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo06
{
    interface IDrive
    {
        string Name { get; set; }

        string Start();
    }
}
