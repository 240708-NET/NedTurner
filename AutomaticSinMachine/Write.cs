class Write{

    Random rand = new Random();
    Sins sins = new Sins();

    public List<string> bootMessages = new List<string>();
    public List<string> computeMessages = new List<string>();

    public Write(){
        this.bootMessages.Add("Beginning Penance Protocol");
        this.bootMessages.Add("Accessing Angel Time");
        this.bootMessages.Add("Initializing Temptation Threshold");
        this.bootMessages.Add("Loading Daily Cringe Forecast");
        this.bootMessages.Add("Calculating Profane Ratio");
        this.bootMessages.Add("Encapsulating E.V.I.L. Packets");
        this.bootMessages.Add("Preparing Augustinian Reference Table");
        this.bootMessages.Add("Updating Insult Catalog");
        this.bootMessages.Add("Is Someone There");
        
        this.computeMessages.Add("Assessing Karmic Signature");
        this.computeMessages.Add("Running P.O.P.E. Algorithm");
        this.computeMessages.Add("Taking tap lessons");
        this.computeMessages.Add("Adjusting For Ambient Wrongdoing");
        this.computeMessages.Add("Processing Moral Implications");
        this.computeMessages.Add("Accounting For THE SUN");
        this.computeMessages.Add("T H E  W O R M  A P P R O A C H E S");
        this.computeMessages.Add("Laying Bare Your Deepest Flaws");
        this.computeMessages.Add("Don't Look Behind You");

    }

    public void PrintThreeMessages(List<string> listOfMessages){
  
        for(int i=0;i<3;i++){
            int toChoose = rand.Next(listOfMessages.Count-1);
            SlowLineBriefPause(listOfMessages[toChoose]);
            listOfMessages.Remove(listOfMessages[toChoose]);
        }

    }


    public bool CheckIfContains(int value, List<int> listOfUsed){
        for(int i=0; i<listOfUsed.Count;i++){
            if(value==listOfUsed[i]){return true;}
        }
        return false;
    }

    public void PrintSin(){
        Console.WriteLine(sins.sinList[rand.Next(sins.sinList.Count-1)]);
    }

    public void SlowLineBriefPause(string toWrite){
        TimedWrite(toWrite,50);
        TimedWrite("...",50);
        Console.WriteLine();
        Thread.Sleep(300); 
    }
    public void FastLineMediumPause(string toWrite){
        TimedWrite(toWrite,20);
        Console.WriteLine();
        Thread.Sleep(600); 
    }

    public void TimedWrite(string toWrite, int typeSpeed){
        foreach(var letter in toWrite){
            Console.Write(letter);
            Thread.Sleep(typeSpeed);
        }
    }

    public void SlowWrite(string toWrite){
        foreach(var letter in toWrite){
            Console.Write(letter);
            Thread.Sleep(50);
        }
    }

    public void RevealSins(){
        string command = Console.ReadLine();
        if(command == "r"){
            sins.RevealAllSins();
        }
    }
    
}