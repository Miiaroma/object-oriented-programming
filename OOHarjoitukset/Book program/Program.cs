using System;

namespace Book_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kirjaohjelma");

            Book newBook = new Book("Kirja1", "Kirjailija1", 12345, 10.50);
            newBook.PrintBookInfo();
            Console.Write("-------------------------------------------------------\n");

            Book newBook2 = new Book("Kirja2", "Kirjailija2", 67890, 15.50);
            //mySecondBook.PrintBookInfo();
            Console.WriteLine(newBook2.PrintBookInfo());
           

            //newBook.CompareBooks(newBook2);
            //Console.WriteLine(newBook.CompareBooks(newBook2);
            //newBook2.CompareBooks(newBook);

            string compareText = newBook.CompareBooks(newBook2);
            Console.WriteLine(compareText);

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
