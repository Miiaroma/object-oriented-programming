using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace File_Manager_Task
{
    public class WordListNotFoundException : Exception
    {
        public WordListNotFoundException(string message) : base(message)
        {

        }
    }

    class FileManager
    {
        private string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public string ReadWords()
        {
            string content = String.Empty;

            try
            {
                content = ReadFile();
            }

            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            return content;
        }

        private string ReadFile()
        {
            if (File.Exists(filePath))
            {
                List<Movie> movieList = JsonConvert.DeserializeObject<List<Movie>>(File.ReadAllText(this.filePath));

                foreach (Movie movie in movieList)
                {
                    Console.WriteLine($"Name: {movie.Name}\nYear: {movie.Year}");
                }
                Console.WriteLine();
            }

            else if (!File.Exists(filePath))
            {
                throw new WordListNotFoundException("File not available");
            }

            string directoryName = Path.GetDirectoryName(filePath);
            string fileName = Path.GetFileName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            Console.WriteLine("directoryName: " + directoryName);
            Console.WriteLine("fileName: " + fileName);
            Console.WriteLine("fileExtension: " + fileExtension);

            string fileContent = File.ReadAllText(filePath, Encoding.UTF8);
            return fileContent;
        }
    }
}
