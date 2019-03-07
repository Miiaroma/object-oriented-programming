using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;


namespace ProductRegister
{
    class ManagerFile
    {
        private string filePath;

        public ManagerFile(string filePath)
        {
            this.filePath = filePath;
        }

        public string ListItems()
        {
            string content = String.Empty;

            try
            {
                content = ReadFile();
            }

            catch (Exception e)
            {
                Console.WriteLine($"Virhe: {e.Message}");
            }
            return content;
        }

        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));

                foreach (Item item in itemList)
                {
                    Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}");
                }
                Console.WriteLine();

                Console.WriteLine("Haluatko tulostaa kaikki tuotetiedot? Vastaa K tai E.");
                string userInput = Console.ReadLine().ToUpper();
                if (userInput == "K")
                {
                    Console.WriteLine("Syötä tuotenumero: ");
                    string id = Console.ReadLine();
                    int.Parse(id);

                    foreach (Item item in itemList)
                    {
                        if (id == item.Id)
                        {
                            Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommenttni: {item.Comment}\n");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tietoja ei tulostettu");
                }
            }

            else if (!File.Exists(filePath))
            {
                throw new Exception("Tiedostoa ei löydy");
            }
            return String.Empty;
        }

        public string ListProductGroup(string productGroup)
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));

            foreach (Item item in itemList)
            {
                switch (productGroup)
                {
                    case "1":
                    case "Lajittelu ja säilytys":
                        break;

                    case "2":
                    case "Paperit ja lehtiöt":
                        break;

                    case "3":
                    case "Kynät":
                        break;

                    case "4":
                    case "Kortit ja kirjekuoret":
                        break;

                    default:
                        Console.WriteLine("Väärä syöte. Valitse numeroista 1-4.");
                        Console.ReadLine();
                        break;
                }
                return $"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n";
            }
            return "";
        }

        public void ListOutOfStock()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));

            foreach (Item item in itemList)
            {
                if (item.Amount == 0)
                {
                    Console.WriteLine($"Nimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}\nHinta: {item.Price}\nMäärä: {item.Amount}\nKommentti: {item.Comment}\n");
                }
            }            
        }

        public void OrderMore()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));

            Console.WriteLine("Syötä tuotenumero: ");
            string id = Console.ReadLine();
            int.Parse(id);

            foreach (Item item in itemList)
            {
                if (id == item.Id && item.Amount == 0)
                {
                    Console.Write($"Lisää kommentti tuotteiden tilaamiseksi:");
                    string comment = Console.ReadLine();
                    item.Comment = comment;
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(itemList));

                    Console.WriteLine($"Kommentti: {item.Comment}");
                }
            }  
            Console.WriteLine("Tuotteita löytyy vielä varastosta");
        }
    }
}

