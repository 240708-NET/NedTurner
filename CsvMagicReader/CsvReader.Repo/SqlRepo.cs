using CsvReader.Models;
using Microsoft.EntityFrameworkCore;

namespace CsvReader.Repo
{
    public class SqlRepo : IRepo
    {

        DataContext context;

        public SqlRepo()
        {
            context = new DataContext();
        }
        
        public List<Tip> GetAllTips()
        {
                return context.Tips.ToList();
        }
        // public List<IObject> GetAll(IObject lister, string filePath)
        // {
        //     using(var context = new DataContext())
        //     {

        //     }
        // }
        public void SaveAllTips(List<Tip> tipList)
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
        public Tip GetTipById(int id)
        {
                Tip? tip = context.Tips.Find(id);
                return tip;
        }
        public void SaveTip(Tip tipToSave)
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


        public bool DeleteTipById(int id)
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
        public void DeleteAllTips()
        {
                foreach(Tip tip in context.Tips)
                { 
                    context.Tips.Remove(tip);
                }
                    context.SaveChanges();
        }

    }
}