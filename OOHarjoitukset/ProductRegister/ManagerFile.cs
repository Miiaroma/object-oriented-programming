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
                    Console.WriteLine($"\nNimi: {item.Name}\nTuotenumero: {item.Id}\nTuoteryhmä: {item.GroupName}");
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
                            Console.WriteLine($"Nimi: {item.Name}" +
                                $"\nTuotenumero: {item.Id}" +
                                $"\nTuoteryhmä: {item.GroupName}" +
                                $"\nHinta: {item.Price}" +
                                $"\nMäärä: {item.Amount}" +
                                $"\nKommentti: {item.Comment}\n");
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
                if (productGroup == "1")
                {

                    if (item.GroupName == "Lajittelu ja säilytys")
                    {
                        Console.WriteLine($"Nimi: {item.Name}" +
                            $"\nTuotenumero: {item.Id}" +
                            $"\nTuoteryhmä: {item.GroupName}" +
                            $"\nHinta: {item.Price}" +
                            $"\nMäärä: {item.Amount}" +
                            $"\nKommentti: {item.Comment}\n");
                    }
                }
                else if (productGroup == "2")
                {
                    if (item.GroupName == "Paperit ja lehtiöt")
                    {
                        Console.WriteLine($"Nimi: {item.Name}" +
                            $"\nTuotenumero: {item.Id}" +
                            $"\nTuoteryhmä: {item.GroupName}" +
                            $"\nHinta: {item.Price}" +
                            $"\nMäärä: {item.Amount}" +
                            $"\nKommentti: {item.Comment}\n");
                    }
                }
                else if (productGroup == "3")
                {
                    if (item.GroupName == "Kynät")
                    {
                        Console.WriteLine($"Nimi: {item.Name}" +
                            $"\nTuotenumero: {item.Id}" +
                            $"\nTuoteryhmä: {item.GroupName}" +
                            $"\nHinta: {item.Price}" +
                            $"\nMäärä: {item.Amount}" +
                            $"\nKommentti: {item.Comment}\n");
                    }
                }
                else if (productGroup == "4")
                {
                    if (item.GroupName == "Kortit ja kirjekuoret")
                    {
                        Console.WriteLine($"Nimi: {item.Name}" +
                            $"\nTuotenumero: {item.Id}" +
                            $"\nTuoteryhmä: {item.GroupName}" +
                            $"\nHinta: {item.Price}" +
                            $"\nMäärä: {item.Amount}" +
                            $"\nKommentti: {item.Comment}\n");
                    }
                }
                else
                {
                    Console.WriteLine("Väärä syöte. Valitse numeroista 1-4.");
                    Console.ReadLine();
                }
            }
            return String.Empty;
        }

        public void ListOutOfStock()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));

            foreach (Item item in itemList)
            {
                if (item.Amount == 0)
                {
                    Console.WriteLine($"\nNimi: {item.Name}" +
                        $"\nTuotenumero: {item.Id}" +
                        $"\nTuoteryhmä: {item.GroupName}" +
                        $"\nHinta: {item.Price}" +
                        $"\nMäärä: {item.Amount}" +
                        $"\nKommentti: {item.Comment}");
                }
            }
            Console.WriteLine();
        }

        public void CommentManager()
        {
            List<Item> itemList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(this.filePath));

            int i = 0;
            foreach (Item item in itemList)
            {
                Console.WriteLine($"{i + 1}.{item.Id}");
                i++;
            }

            Console.WriteLine("Syötä tuotenumero: ");
            string id = Console.ReadLine();
            int.Parse(id);

            foreach (Item item in itemList)
            {
                if (id == item.Id)
                {
                    Console.Write($"Lisää kommentti:");
                    string comment = Console.ReadLine();
                    item.Comment = comment;
                    File.WriteAllText(filePath, JsonConvert.SerializeObject(itemList));

                    Console.WriteLine($"Kommentti: {item.Comment}");
                }
                else
                    Console.WriteLine("Kommenttia ei lisätty.");
            }
        }
    }
}


