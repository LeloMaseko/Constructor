using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry", "JK rowling", 600);


            Book book2 = new Book("Lord of the rings","Tolkein",900);
            
            Console.WriteLine(book1.title);
            Console.ReadKey();
        }
    }
}
