using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB12_KTP
{
    internal class Book
    {
        public string Title;
        public string Author;
        public int YearPublished;
        public double Price;
        // Параметричний конструктор
        public Book(string title, string author, int yearPublished, double price)
        {
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            Price = price;
        }
        // Метод для виведення інформації
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Назва: {Title}, Автор: {Author}, Рік видання: {YearPublished}, Ціна: {Price} грн.");
        }
    }
}
