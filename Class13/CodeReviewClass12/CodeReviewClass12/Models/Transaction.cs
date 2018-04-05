using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeReviewClass12.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Book Book { get; set; }
    }
}
