using System;
using Literature;

namespace BookAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kirjojen ja kirjailijoiden tiedot");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book firstBook = new Book("C# ohjelmointi", "G. Moghadampour", "WSOYPro", 0.00, "Oppikirja.");            
            firstBook.Price = 30.5;
            Book secondBook = new Book("Koiramäen talvi", "M. Kunnas", "Otava", 0.00, "Lastenkirja.");
            secondBook.Price = 20.10;
            

            firstBook.SearchBook();
            secondBook.SearchBook();
            Book.ChangeTheme();            

            Console.WriteLine($"Kirjan {firstBook.title} kirjailija on {firstBook.Author}.\n");
            Console.WriteLine($"Kirjan {secondBook.title} kirjailija on {secondBook.Author}.\n");

            Author author = new Author ("M. Kunnas", "11.2.1950", secondBook);
            
            author.PrintInfo();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }        
    }
}
