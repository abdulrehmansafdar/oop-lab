using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class Program
    {
     
        static void Main(string[] args)
        {
            
               
              
                
                    Book book = new Book("C#", 500,"Ali","ali@gmail.com");
            Book book1 = new Book("C#", 500, "Ali", "ali@gmail.com");

            Console.WriteLine(book.GetTitleBook());
            book1.SetTitleBook("oop");
            Console.WriteLine(book1.GetTitleBook());
           

            Console.ReadLine();



        }
    }
}
