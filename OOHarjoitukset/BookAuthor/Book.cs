using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace Literature
{
    class Book
    {
        public string title;
        public readonly string author;
        public string publisher;
        private double _price;
        public static string theme;

        public Book()
        {
            this.title = String.Empty;
            this.author = String.Empty;
            this.publisher = String.Empty;
            this._price = 0;
            theme = String.Empty;
        }

        public Book(string title, string author, string publisher, double price, string themeName)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            theme = themeName;
        }

        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan tiedot ovat \nNimi: {this.title}\nKirjailija: {this.author}\nKustantaja: {this.publisher}\nHinta: {this.Price:c}\nTeema: {theme}");
        }

        public void SearchBook()
        {
            Console.WriteLine("Etsi kirja, jonka nimi on: ");
            string name = Console.ReadLine();
            Console.WriteLine();

            if (name == this.title)
            {
                Console.WriteLine($"Kirjan tiedot ovat \nNimi: {this.title}\nKirjailija: {this.author}\nKustantaja: {this.publisher}\nHinta: {this.Price:c}\nTeema: {theme}\n");
            }

            else
            {
                Console.WriteLine("Kirjaa ei löytynyt.\n");
            }
        }
        
        public static void ChangeTheme()
        {
            Console.WriteLine("Anna uusi teema: ");
            string themeName = Console.ReadLine();
            theme = themeName;
            Console.WriteLine();
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                if (value > 30)
                {
                    _price = value * 0.9;
                }

                else
                {
                    _price = value;
                }
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }
    }
}
