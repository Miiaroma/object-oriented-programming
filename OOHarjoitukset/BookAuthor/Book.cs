using System;
using System.Collections.Generic;
using System.Text;

namespace BookAuthor
{
    class Book
    {
        public string title;
        readonly string author;
        public string publisher;
        private double price;
        public static string theme;

        public Book()
        {
            this.title = String.Empty;
            this.author = String.Empty;
            this.publisher = String.Empty;
            this.price = 0;
            theme = String.Empty;
        }

        public Book(string title, string author, string publisher, double price, string themeName)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.price = price;
            theme = themeName;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan tiedot ovat nimi: {this.title}\nKirjailija: {this.author}\nKustantaja: {this.publisher}\nHinta: {this.price:c}\nTeema: {theme}");
        }

        public void SearchBook()
        {
            Console.WriteLine("Etsi kirja, jonka nimi on: ");
            string name = Console.ReadLine();

            if (name == this.title)
            {
                Console.WriteLine($"Kirjan tiedot ovat nimi: {this.title}\nKirjailija: {this.author}\nKustantaja: {this.publisher}\nHinta: {this.price:c}\nTeema: {theme}");
            }

            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.");
            }
        }
        
        public static void ChangeTheme()
        {
            Console.WriteLine("Anna uusi teema: ");
            string themeName = Console.ReadLine();            
        }

        public double Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value > 30)
                {
                    price = value * 0.9;
                }

                else
                {
                    price = value;
                }
            }
        }

        public string Author
        {
            get
            {
                return this.author;
            }
        }
    }
}
