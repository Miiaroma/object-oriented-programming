using System;

namespace Book_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on kirjaohjelma\n");

            Book newBook = new Book("Kirja_1", "Kirjailija_A", 12345, 10);
            Console.WriteLine(newBook.PrintBookInfo());
            Console.WriteLine();

            Book newBook2 = new Book("Kirja_2", "Kirjailija_B", 67890, 15);
            Console.WriteLine(newBook2.PrintBookInfo());
            Console.WriteLine();

            string compareText = newBook.CompareBooks(newBook2);
            Console.WriteLine(compareText);

            Console.Write("Press any key to continue...\n");
            Console.ReadKey();
        }
    }
}
