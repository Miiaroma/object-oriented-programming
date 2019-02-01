using System;
using System.Collections.Generic;
using System.Text;

namespace Literature
{
    class Author
    {
        public string name;
        public string birthday;
        public Book book;

        public Author()
        {
            this.name = String.Empty;
            this.birthday = String.Empty;
        }


        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.book = book;
        }


        public void PrintInfo()
        {
            Console.WriteLine($"Kirjailijan mimi: {this.name}\n" +
                $"Syntymäpäivä: {this.birthday}\n");
            this.book.PrintBookInfo();
        }
    }
}