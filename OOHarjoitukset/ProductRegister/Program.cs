using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ProductRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            string message = string.Empty;
            //string filePath = @"C:\Dev\object-oriented-programming\OOHarjoitukset\ProductRegister\items.json";
            string filePath = "items.json";

            ManagerFile managerFile = new ManagerFile(filePath);
            Item item = new Item();

            do
            {
                cki = UserInterface();
                switch (cki.Key)
                {
                    case ConsoleKey.L:
                        Console.WriteLine(managerFile.ListItems());
                        message = "Valitut tuotetiedot listattu. \nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.T:
                        Console.Write("\nValitse tuoteryhmä, syötä numero:\n" +
                            "1 = Lajittelu ja säilytys\n" +
                            "2 = Paperit ja lehtiöt\n" +
                            "3 = Kynät\n" +
                            "4 = Kortit ja kirjekuoret\n");
                        string productGroup = Console.ReadLine();
                        Console.WriteLine(managerFile.ListProductGroup(productGroup));
                        message = "Valitun tuoteryhmän tiedot listattu.\nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.V:
                        managerFile.ListOutOfStock();
                        message = "\nVarastosta loppuneet tuotteet listattu. \nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.K:
                        managerFile.NewComment();
                        message = "Kommentit käsitelty. \nPaina Enter jatkaaksesi!";
                        break;

                   case ConsoleKey.P:
                        managerFile.RemoveComment();
                        message = "Kommentit käsitelty. \nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.Escape:
                        message = "\nOhjelman suoritus päättyy.";
                        break;

                    default:
                        message = "Virhe - Paina Enter ja aloita alusta!";
                        break;
                }
                Console.WriteLine(message);
                Console.ReadLine();
                Console.Clear();
            } while (cki.Key != ConsoleKey.Escape);

            Console.WriteLine("Ohjelman suoritus päättyi!");
        }

        static ConsoleKeyInfo UserInterface()
        {
            Console.WriteLine("Tuoterekisteri");
            Console.WriteLine("[L] Listaa kaikki tuotteet");
            Console.WriteLine("[T] Listaa tietyn tuoteryhmän tiedot");
            Console.WriteLine("[V] Listaa varastosta loppuneet tuotteet");
            Console.WriteLine("[K] Lisää kommentti");
            Console.WriteLine("[P] Poista kommentti");
            Console.WriteLine("[ESC] Lopeta ohjelman suoritus");
            Console.WriteLine();
            Console.WriteLine("Valitse vaihtoehto:");

            return Console.ReadKey();
        }

    }
}
