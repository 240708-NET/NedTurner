using CsvReader.Models;

namespace CsvReader.Repo
{
    public class SqlRepo : IRepo
    {
        
        public List<Tip> GetAllTips()
        {
            using(var context = new DataContext())
            {
                return context.Tips.ToList();
            }
        }
        // public List<IObject> GetAll(IObject lister, string filePath)
        // {
        //     using(var context = new DataContext())
        //     {

        //     }
        // }
        public void SaveAllTips(List<Tip> tipList)
        {
            using(var context = new DataContext())
            {
                foreach(Tip tip in tipList)
                {
                    Tip? savedTip = context.Tips.Find(tip.order_id);
                    if(savedTip == null)
                    {
                        context.Tips.Add(tip);
                    }
                    else if (savedTip != null)
                    {
                        savedTip.day = tip.day;
                        savedTip.time = tip.time;
                        savedTip.size = tip.size;
                        savedTip.smoker = tip.smoker;
                        savedTip.sex = tip.sex;
                        savedTip.total_bill = tip.total_bill;
                        savedTip.tip = tip.tip;
                    }
                }
                context.SaveChanges();
            }
        }
        public Tip GetTipById(int id)
        {
            using(var context = new DataContext())
            {
                Tip? tip = context.Tips.Find(id);
                return tip;
            } 
        }
        public void SaveTip(Tip tipToSave)
        {
            using(var context = new DataContext())
            {
                Tip? savedTip = context.Tips.Find(tipToSave.order_id);

                if(savedTip != null)
                {
                    savedTip.day = tipToSave.day;
                    savedTip.time = tipToSave.time;
                    savedTip.size = tipToSave.size;
                    savedTip.smoker = tipToSave.smoker;
                    savedTip.sex = tipToSave.sex;
                    savedTip.total_bill = tipToSave.total_bill;
                    savedTip.tip = tipToSave.tip;
                }else
                {
                    context.Add(tipToSave);
                }
                
                context.SaveChanges();

            }
        }
        public bool DeleteTipById(int id)
        {
            using(var context = new DataContext())
            {
                var tip = context.Tips.Find(id); 
                if(tip != null)
                {
                    context.Tips.Remove(tip);
                    context.SaveChanges();
                    return !context.Tips.Contains(tip);
                }
                return false;


            } 
        }

    }
}