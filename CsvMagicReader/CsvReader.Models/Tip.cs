namespace CsvReader.Models;

public class Tip : IObject
{

    public static string csvFirstLine = "order_id,day,time,size,smoker,sex,total_bill,tip";

    // [Key]
    public int? order_id {get;set;}
    public string day {get;set;}
    public string time {get;set;}
    public int size {get;set;}
    public bool smoker {get;set;}
    public string sex {get;set;}
    public float total_bill {get;set;}
    public float tip {get;set;}


    public Tip(){}
    public Tip(int order_id,string day,string time,int size,bool smoker,string sex,float total_bill,float tip){
    this.order_id =order_id;
    this.day =day;
    this.time =time;
    this.size =size;
    this.smoker = smoker;
    this.sex =sex;
    this.total_bill =total_bill;
    this.tip =tip;
    }

    public override Tip ListToObject(List<string> tipList)
    {
        return Tip.ListToTip(tipList);
    }
    // public Tip ListToObject<Tip>(List<string> tipList) where Tip : new()
    // {
    //     Tip newTip = new Tip();

    //     int counter = 0;
    //     newTip.order_id = Int32.Parse(tipList[counter++]);
    //     newTip.day = tipList[counter++];
    //     newTip.time = tipList[counter++];
    //     newTip.size = int.Parse(tipList[counter++]);
    //     newTip.smoker = (tipList[counter++]=="yes") ? true : false;
    //     newTip.sex = tipList[counter++];
    //     newTip.total_bill = float.Parse(tipList[counter++]);
    //     newTip.tip = float.Parse(tipList[counter++]);

    //     return newTip;

    // }
    // public Tip ListToObject<Tip>(List<string> tipList) where Tip : new(int ,string ,string ,int ,bool ,string,float,float)
    // {

    //     int counter = 0;

    //     Tip tip = new Tip(
    //                 Int32.Parse(tipList[counter++]),
    //                 tipList[counter++],
    //                 tipList[counter++],
    //                 int.Parse(tipList[counter++]),
    //                 (tipList[counter++]=="yes") ? true : false,
    //                 tipList[counter++],
    //                 float.Parse(tipList[counter++]),
    //                 float.Parse(tipList[counter++])
    //                 );
    //     return tip;
    // }

    public static Tip ListToTip(List<string> tipList)
    {
        Tip newTip = new Tip();

        int counter = 0;
        newTip.order_id = Int32.Parse(tipList[counter++]);
        newTip.day = tipList[counter++];
        newTip.time = tipList[counter++];
        newTip.size = int.Parse(tipList[counter++]);
        newTip.smoker = (tipList[counter++]=="yes") ? true : false;
        newTip.sex = tipList[counter++];
        newTip.total_bill = float.Parse(tipList[counter++]);
        newTip.tip = float.Parse(tipList[counter++]);

        return newTip;
    }

    public static string DayContractionCompleter(string dayContraction)
    {
        switch(dayContraction)
        {
            case "Sun":
            return "Sunday";
            case "Mon":
            return "Monday";
            case "Tue":
            return "Tuesday";
            case "Wed":
            return "Wednesday";
            case "Thur":
            return "Thursday";
            case "Fri":
            return "Friday";
            case "Sat":
            return "Saturday";
        }
        return "Tubesdate";
    }

    public override string Describe()
    {
        string smokeType = this.smoker ? "smoking" : "non-smoking";
        return $"Order {this.order_id}: On {DayContractionCompleter(this.day)} during {this.time.ToLower()} a {this.sex.ToLower()} customer in a {smokeType} party of {this.size} left a tip of ${this.tip} on a bill of ${this.total_bill}.";
    }
    public override string ToString()
    {
        string smokeType = this.smoker ? "Yes" : "No";
        return $"{this.order_id},{this.day},{this.time},{this.size},{smokeType},{this.sex},{this.total_bill},{this.tip}";
    }

}
