using System;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int counter = 0;
                string line;

                using (StreamReader sr = new StreamReader(@"C:\Users\320028367\source\repos\ConsoleApp8\ConsoleApp8\Util\url.txt"))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string decodedUrl = Uri.UnescapeDataString(line);
                        UriBuilder baseUri = new UriBuilder(decodedUrl);
                        Console.WriteLine(baseUri);
                        counter++;
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

    }
}
