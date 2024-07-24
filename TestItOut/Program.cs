

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Bumpus");
        stringList.Add("Yoooo");
        stringList.Remove("Bumpus");
        stringList[0] = "Hey there";

    foreach(var word in stringList)
    {
        Console.WriteLine(word);
    }
    


    SELECT TOP 1 * FROM employee ORDER BY Salary;


    static void Main(string[] args)
    {int a = 1, b = 2;  Console.WriteLine($"{a}+{b}");}