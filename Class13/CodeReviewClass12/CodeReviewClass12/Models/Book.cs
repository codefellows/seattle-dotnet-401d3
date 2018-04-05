using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeReviewClass12.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }


        public List<Book> BuildBooks()
        {
            return new List<Book>() {
                new Book(){Name="Harry Potter and the Sorcerer's Stone", Author="JK Rowling", NumberOfPages=309 },
                new Book(){Name="Harry Potter and the Chamber of Secrets", Author="JK Rowling", NumberOfPages=251},
                new Book(){Name="Harry Potter and the Prison of Azkaban", Author="JK Rowling", NumberOfPages=317 },
                new Book(){Name="Green Eggs and Ham", Author="Dr. Suess", NumberOfPages=72 },
                new Book(){Name="Where the sidewalk ends", Author="Shell Sylverstein", NumberOfPages= 166 },
                new Book(){Name="The Givign Tree", Author="Shell Sylverstein", NumberOfPages= 64 },

            };
        }
    }
}
