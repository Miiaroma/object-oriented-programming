using System;

namespace File_Manager_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The program prints information on movies and files, " +
                "and an error message if the file not found.\n");

            string filePath = @"C:\Dev\object-oriented-programming\OOHarjoitukset\File Manager Task\movie.json"; 
            
            FileManager fileManger = new FileManager(filePath);

            fileManger.ReadWords();

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
