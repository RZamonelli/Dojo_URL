using System;
using System.Collections.Generic;
using System.IO;

namespace URL
{
    class ProcessURL
    {
        private static ProcessURL _instance;

        static ProcessURL()
        {
            _instance = new ProcessURL();
        }

        public static ProcessURL Instance()
        {
            return _instance;
        }

        public void AnalyzeURL(string url)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           int counter = 0;
           string line;

           using (StreamReader sr = ReadListUrl())
           {
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        string baseUrl = new UriBuilder(line).ToString();
                        ProcessURL.Instance().AnalyzeURL(baseUrl);                        
                    }
                    catch (UriFormatException e)
                    {
                        Console.WriteLine(e.Message + " URL: " + line);
                    }                 
                 
                    counter++;
               }
            }

           Console.ReadKey();
        }

        private static StreamReader ReadListUrl()
        {
            try
            {
              return new StreamReader(@"C:\Users\Renan\Documents\GitHub\Dojo_URL\Util\url.txt");//change this path              
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
