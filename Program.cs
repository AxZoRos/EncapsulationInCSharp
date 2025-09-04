using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_KTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; 
            Book book = new Book("The Power of Now: A Guide to Spiritual Enlightenment", "Екхарт Толле", 2017, 415);
            book.DisplayBookInfo();// Метод для виводу інформації про книгу.
            Console.ReadLine();
        }
    }
}
