using CsvReader.Models;

namespace CsvReader.Repo
{
    public interface IRepo
    {
        public List<Tip> GetAllTips();
        // public List<IObject> GetAll(IObject lister, string filePath);
        public void SaveAllTips(List<Tip> tipList);
        public Tip GetTipById(int id);
        
        public Tip GetTipByOrderId(int id);
        public void SaveTip(Tip tipToSave);
        public bool DeleteTipById(int id);
        public bool DeleteTipByOrderId(int order_id);
        public void DeleteAllTips();
        public List<Tip> LoadTipsFromFile();

        
    }
}