using System;

namespace BookAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirja- ja Kirjailija -luokka");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Book firstBook = new Book("Kirja1", "Kirjailija_A", "Otava", 0.00, "Tietokirja.");            
            firstBook.Price = 30.5;
            Book secondBook = new Book("Kirja2", "Kirjailija_B", "WSOY", 0.00, "Kaunokirjallisuus.");
            secondBook.Price = 20.10;
            Book thirdBook = new Book("Kirja3", "Kirjailija_C", "Otava", 0.00, "Lastenkirja.");
            secondBook.Price = 20.10;

            //Book.SearchBook();
            Book.ChangeTheme();

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }        
    }
}
