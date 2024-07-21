
using System.ComponentModel.DataAnnotations;

namespace CsvReader.Models
{
    public class Honey : IObject
    {

        [Key]
        public int id {get;set;}

        public Honey(){}

        // public override IObject ListToObject<IObject>(List<string> rawHoney) where IObject : new()
        // {
        //     return new Honey();
        // }
        public override Honey ListToObject(List<string> rawHoney)
        {
            return new Honey();
        }

        public override string Describe(){
            return "";
        }
    }
}