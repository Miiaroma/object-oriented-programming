using System;

namespace File_Manager_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This FileManager program prints information on movies and files.\n");

            string filePath = @"C:\Dev\object-oriented-programming\OOHarjoitukset\File Manager Task\movie.json"; 
            
            FileManager fileManger = new FileManager(filePath);

            fileManger.ReadWords();

            Console.WriteLine("Press enter to continue..");
            Console.ReadLine();
        }
    }
}
