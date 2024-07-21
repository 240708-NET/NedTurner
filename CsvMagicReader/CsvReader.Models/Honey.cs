namespace CsvReader.Models
{
    public class Honey : IObject
    {

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