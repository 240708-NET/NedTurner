using CsvReader.Models;

namespace CsvReader.Repo
{

public class CsvLooker : IRepo
{
        static string basePath = "../Files/Csv_Files/";
        static Tip tipper = new();

        public CsvLooker()
        {
            Console.WriteLine("yo");
        }


        public List<Tip> GetAllTips()
        {
            List<Tip> tips = new();
            string filePath = "tips.csv";

            List<List<string>> tipStringList = ReadEntireCsv(filePath);
            tipStringList.RemoveAt(0);

            foreach(List<string> rawTip in tipStringList)
            {
                // tips.Add(Tip.ListToTip(rawTip));
                tips.Add(tipper.ListToObject(rawTip));
            }
            return tips;

        }

        
        // public List<IObject> GetAll(IObject lister, string filePath)
        // {
        //     List<IObject> objectList = new();

        //     List<List<string>> tipStringList = ReadEntireCsv(filePath);
        //     tipStringList.RemoveAt(0);

        //     foreach(List<string> rawTip in tipStringList)
        //     {
        //         // tips.Add(Tip.ListToTip(rawTip));
        //         objectList.Add(lister.ListToObject(rawTip));
        //     }
        //     return objectList;

        // }

        public void SaveAllTips(List<Tip> tipList)
        {
            string filePath = "tips.csv";
            string stringToSave = Tip.csvFirstLine +"\n";

            foreach(var tip in tipList)
            {
                stringToSave += tip.ToString()+"\n";
            }
            File.WriteAllText(basePath+filePath,stringToSave);
            
        }


        public Tip GetTipById(int id)
        {
            List<Tip> tipList = GetAllTips();
            foreach(Tip t in tipList)
            {
                if(t.order_id == id)
                {
                    return t;
                }
            }
            throw new Exception("ID not found");
        }


        public void SaveTip(Tip tipToSave)
        {
            List<Tip> tipList = GetAllTips();

            int index = tipList.FindIndex(tip=> tip.order_id == tipToSave.order_id);
            if(index!=-1) tipList[index] = tipToSave;
            else tipList.Add(tipToSave);

            SaveAllTips(tipList);
        }


        public bool DeleteTipById(int id)
        {
            List<Tip> tipList = GetAllTips();

            int index = tipList.FindIndex(tip=> tip.order_id == id);
            if(index!=-1) 
            {
                tipList.RemoveAt(index);
                SaveAllTips(tipList);
                return true;
            }
            else throw new Exception("ID not found");

        }



    

        /* 
        Eventually, I'd like to make a function that can read the first line of the CSV file,
        compare that line to the csvFirstLine properties of all other extant files and determine its object type
        
        For real pie in the sky, if not object type is found, then a new object type is dynamically created
        
        */
        public static List<List<string>> ReadEntireCsv(string fileName)
        {
            using(StreamReader reader = new StreamReader(basePath + fileName))
            {
            List<List<string>> csvContents = new();
            
            while(!reader.EndOfStream)
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
                
            }

            return csvContents;
            }
        }

}
}