
public class Tip
{

    public static string csvFirstLine = "order_id,day,time,size,smoker,sex,total_bill,tip";

    public int? id {get;set;}
    public int order_id {get;set;}
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

    public string Describe()
    {
        string smokeType = this.smoker ? "smoking" : "non-smoking";
        return $"Order {this.order_id}: On {DayContractionCompleter(this.day)} during {this.time.ToLower()} a {this.sex.ToLower()} customer in a {smokeType} party of {this.size} left a tip of ${this.tip} on a bill of ${this.total_bill}.";
    }
    public override string ToString()
    {
        string smokeType = this.smoker ? "Yes" : "No";
        return $"{this.order_id},{this.day},{this.time},{this.size},{smokeType},{this.sex},{this.total_bill},{this.tip}";
    }

    public override bool Equals(object? obj)
    {
        var item = obj as Tip;
        if(item==null) return false;
        if(this.order_id !=item.order_id) return false;
        if(this.day !=item.day) return false;
        if(this.time !=item.time) return false;
        if(this.size !=item.size) return false;
        if(this.smoker !=item.smoker) return false;
        if(this.sex !=item.sex) return false;
        if(this.total_bill !=item.total_bill) return false;
        if(this.tip !=item.tip) return false;
        return true;
    }

}
