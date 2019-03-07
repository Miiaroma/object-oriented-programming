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
            string filePath = @"C:\Dev\object-oriented-programming\OOHarjoitukset\ProductRegister\items.json";

            ManagerFile managerFile = new ManagerFile(filePath);
            Item item = new Item();

            do
            {
                cki = UserInterface();
                switch (cki.Key)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine(managerFile.ListItems());
                        message = "Valitut tuotetiedot listattu. \nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.F2:
                        Console.WriteLine("Valitse tuoteryhmä, syötä numero:\n" +
                            "1 = Lajittelu ja säilytys\n" +
                            "2 = Paperit ja lehtiöt\n" +
                            "3 = Kynät\n" +
                            "4 = Kortit ja kirjekuoret");
                        string productGroup = Console.ReadLine();                        
                        Console.WriteLine(managerFile.ListProductGroup(productGroup));
                        message = "Valitun tuoteryhmän tiedot listattu.\nPaina Enter jatkaaksesi!";
                        break;

                    case ConsoleKey.F3: 
                        managerFile.ListOutOfStock();
                        managerFile.OrderMore();
                        message = "Varastosta loppuneet tuotteet listattu ja tarvittavat toimenpiteet tehty. \nPaina Enter jatkaaksesi!"; 
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
            Console.WriteLine("[F1] Listaa kaikki tuotteet");
            Console.WriteLine("[F2] Listaa tietyn tuoteryhmän tiedot");
            Console.WriteLine("[F3] Listaa varastosta loppuneet tuotteet");
            Console.WriteLine("[ESC] Lopeta ohjelman suoritus");
            Console.WriteLine();
            Console.WriteLine("Valitse vaihtoehto:");

            return Console.ReadKey();
        }

    }
}
