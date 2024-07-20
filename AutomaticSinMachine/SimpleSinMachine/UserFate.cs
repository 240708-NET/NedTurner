class UserFate{
    public string name = "";
    public int age;
    public string color = "";

    public int sinMeter;


    public void CalculateSinMeter(){
        this.sinMeter = ((this.name.Length + this.color.Length)%6)-(this.age%5);
    }
}