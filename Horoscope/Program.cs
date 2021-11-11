using System;
using System.IO;
namespace DataFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite horoscope");
            string userHoroscope = Console.ReadLine();

            string output = GetLineFromData(userHoroscope);

            if (output.Length != 0)
            {
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine("sorry, i don't know that sign.");
            }

        }
        private static string[] ReadDataFromFile()
        {
            string directoryPath = @"C:\Users\opilane\Samples";
            string fileName = "horoscope.txt";
            string fullPath = $@"{directoryPath}\{fileName}";

            string[] dataFromFile = File.ReadAllLines(fullPath);

            return dataFromFile;
        }

        private static string GetLineFromData(string userInput)
        {
            string[] dataFromFile = ReadDataFromFile();
            string result = "";

            foreach (string line in dataFromFile)
            {
                if (line.Contains(userInput))
                {
                    result = line;
                    break;

                }
            }
            return result;
        }
    }
    
    
}


