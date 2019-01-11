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

        public Book(string title, string author, int idNumber, double price)
        {
            this.title = title;
            this.author = author;
            this.idNumber = idNumber;
            this.price = price;
            //Console.WriteLine($"Luotu kirja {this.title}, jonka kirjoittajan nimi on {this.author}, id-numero {this.idNumber}, hinta {this.price}");
        }

        public string CompareBook(Book book)
        {
            string text = "";
            Console.WriteLine($"Kirja: {this.title} - Hinta: {this.price.ToString()}\n");
            Console.WriteLine($"Kirja: {book.title} - Hinta: {book.price.ToString()}\n");

            if (this.price > book.price)
            {
                text = $"Kirja: {this.title} - Hinta: {this.price.ToString()} on kalliimpi.\n";
            }

            else if (this.price == book.price)
            {
                text = $"Kirjat: {this.title} ja {book.title} - Hinnat: {book.price.ToString()} ovat saman hintaisia.\n";
            }

            else
            {
                text = $"Kirja: {book.title} - Hinta: {book.price.ToString()} on kalliimpi.\n";
            }
            return text;
        }

        public string PrintBookInfo()
        {
            return $"Kirjan tiedot ovat {this.title}, kirjoittaja {this.author}, id-numero {this.idNumber}, hinta {this.price}.";
        }
    }
}
