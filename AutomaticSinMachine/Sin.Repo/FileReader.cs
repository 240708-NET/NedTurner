using System;
using System.IO;

namespace Sin.Repo
{
    public class FileReader : IRepo
    {
        string path = "../Project1_CSV/tips.csv";

        public FileReader()
        {
            Console.WriteLine("yo");
        }

        public List<List<string>> ReadCsv()
        {
            StreamReader reader = new StreamReader(path);
            int counter = 0;
            List<List<string>> csvContents = new();
            
            while(!reader.EndOfStream && counter<6)
            {
                var line = reader.ReadLine();

                var values = line.Split(',');
                List<string> row = new List<string>();

                foreach(var value in values)
                {
                    // Console.Write(value + " ");
                    row.Add(value);
                }

                csvContents.Add(row);
                
                // Console.WriteLine();
                
                counter++;
            }

            reader.Close();
            return csvContents;
        }


        public static void Print2DArray(List<List<string>> matrix)
        {
        foreach(List<string> listOfItems in matrix)
        {
            foreach(string item in listOfItems)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        }

    

    }
}