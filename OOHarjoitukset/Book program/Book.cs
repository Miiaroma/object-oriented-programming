using System;
using System.Collections.Generic;
using System.Text;

namespace Book_program
{
    class Book
    {
        public string title;
        public string author;
        public int idNumber;
        public double price;

        public Book()
        {
            this.price = 10.50;
        }

        //Constructor
        public Book(string title, string author, int idNumber, double price)
        {
            this.title = title;
            this.author = author;
            this.idNumber = idNumber;
            this.price = price;
            Console.WriteLine($"Luotu kirja {this.title}, jonka kirjoittajan nimi on {this.author}, id-numero {this.idNumber}, hinta {this.price}");
        }

        public Book (double price)
        {
            this.price = price;
            //Console.WriteLine($"Kirjan hinta on {this.price}");
        }

        public string CompareBooks(Book book)
        {
            string text = "";
            Console.WriteLine($"Kirja: {this.title} - Hinta:{this.price.ToString()}\n");
            Console.WriteLine($"Kirja: {book.title} - Hinta:{book.price.ToString()}\n");
            if (this.price > book.price)
            {
                //Console.WriteLine($"Kirja: {this.title} Hinta:{this.price.ToString()} on kalliinpi\n");
                text = $"Kirja: {this.title} Hinta: {this.price.ToString()} on kalliinpi\n";
            }
            else
            {
                //Console.WriteLine($"Kirja: {book.title} Hinta:{book.price.ToString()} on kalliinpi\n");
                text = $"Kirja: {book.title} Hinta:{book.price.ToString()} on kalliinpi\n";
            }
            return text;        
        }

        public string PrintBookInfo()
        {
            //Console.WriteLine($"Kirjan tiedot ovat {this.title}, kirjoittaja {this.author}, id-numero {this.idNumber}, hinta {this.price}");
            return $"Kirjan tiedot ovat {this.title}, kirjoittaja {this.author}, id-numero {this.idNumber}, hinta {this.price}";
        }
    }
}
