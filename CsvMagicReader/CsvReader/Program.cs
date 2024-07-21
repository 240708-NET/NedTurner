using CsvReader.Repo;
using CsvReader.Models;


namespace CsvReader
{
    class CsvReader
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello again!");



            IRepo csvReader = new CsvLooker();
            IRepo jsonReader = new JsonLooker("tips.json");
            IRepo sqlRepo = new SqlRepo();
            List<Tip> allTips = csvReader.GetAllTips();
            // Tip tipper = new();
            // List<Tip> allTips = reader.GetAll(tipper, "tips.csv");

            // // PRINT ONLY FIRST TEN OBJECTS IN LIST
            // for(int i =0; i<10;i++)
            // {
            //     Console.WriteLine(allTips[i].Describe());
            // }

            // PRINT ALL OBJECTS IN LIST
            foreach(Tip tip in allTips)
            {
                Console.WriteLine(tip.ToString());
            }

            // sqlRepo.SaveAllTips(allTips);

            // //TEST FOR SINGLE TIP OBJECT
            List<string> newTipList = new List<string>{"245","Tuesday", "Lunch", "5", "No", "Male","999.09","20.00"};
            Tip newTip = Tip.ListToTip(newTipList);
            Console.WriteLine(newTip.ToString());

            // sqlRepo.SaveTip(newTip);
            jsonReader.SaveAllTips(allTips);

            // reader.DeleteTipById(245);

            // Console.WriteLine(reader.GetTipById(74).Describe());



        }
    }
}