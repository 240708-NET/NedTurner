using CsvReader.Models;
using System.Text.Json;

namespace CsvReader.Repo
{
    public class JsonLooker : IRepo
    {

        private static readonly string basePath = "../Files/Json_Files/";
        private readonly string _filePath = "";

        public JsonLooker(string fileName)
        {
            this._filePath = basePath+fileName;
            if(!File.Exists(_filePath))
            {
                File.WriteAllText(_filePath,"");
            }
        }

        public List<Tip> GetAllTips()
        {
            string json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Tip>>(json);
        }

        // public List<IObject> GetAll(IObject lister, string filePath);
        public void SaveAllTips(List<Tip> tipList)
        {
            string allTips = JsonSerializer.Serialize(tipList);
            File.WriteAllText(_filePath,allTips);   
        }
        public Tip GetTipById(int id)
        {
            List<Tip> tipList = GetAllTips();
            var foundTip =
                    from t in tipList
                    where t.order_id == id
                    select t;
            if(foundTip == null)
            {
                throw new Exception("Id not found");
            }
            return foundTip.First();
        }
        
        public Tip GetTipByOrderId(int id)
        {
            return GetTipById(id);
        }
        public void SaveTip(Tip tipToSave)
        {
            List<Tip> tipList = GetAllTips();
            int index = tipList.FindIndex(tip=> tip.order_id == tipToSave.order_id);
            if(index!=-1) tipList[index] = tipToSave;
            else tipList.Add(tipToSave);

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
        public bool DeleteTipByOrderId(int order_id)
        {
            return DeleteTipById(order_id);
        }

        
        public void DeleteAllTips(){}

        public List<Tip> LoadTipsFromFile()
        {
            return GetAllTips();
        }
    }
}