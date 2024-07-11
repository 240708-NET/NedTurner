class Write(Random rando, Messages messages)
{

    readonly Random rand = rando;
    readonly Messages messages = messages;

    public void PrintMessageXTimes(List<string> listOfMessages,int timesToPrint,string printSpeed){
  
        for(int i=0;i<timesToPrint;i++){
            int toChoose = rand.Next(listOfMessages.Count-1);
            if(printSpeed == "slow"){
            SlowLineBriefPause(listOfMessages[toChoose]);
            }else{
                FastLineMediumPause(listOfMessages[toChoose]);
            }
            listOfMessages.Remove(listOfMessages[toChoose]);
        }

    }
    // public void PrintThreeMessages(List<string> listOfMessages){
  
    //     for(int i=0;i<3;i++){
    //         int toChoose = rand.Next(listOfMessages.Count-1);
    //         SlowLineBriefPause(listOfMessages[toChoose]);
    //         listOfMessages.Remove(listOfMessages[toChoose]);
    //     }

    // }

    public void AcceptValues(string requestValueMessage){
        
        SlowWrite(requestValueMessage);
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string name = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        Thread.Sleep(500);
        PrintMessageXTimes(messages.sassMessages,1,"fast");
        Console.WriteLine();
    }


    public static void SlowLineBriefPause(string toWrite){
        TimedWrite(toWrite,50);
        TimedWrite("...",50);
        Console.WriteLine();
        Thread.Sleep(300); 
    }
    public static void FastLineMediumPause(string toWrite){
        TimedWrite(toWrite,20);
        Console.WriteLine();
        Thread.Sleep(600); 
    }

    public static void TimedWrite(string toWrite, int typeSpeed){
        foreach(var letter in toWrite){
            Console.Write(letter);
            Thread.Sleep(typeSpeed);
        }
    }

    public static void SlowWrite(string toWrite){
        foreach(var letter in toWrite){
            Console.Write(letter);
            Thread.Sleep(50);
        }
    }

    public void RevealAllContents(List<string> messageList){

            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string command = Console.ReadLine();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        if (command == "r"){
            foreach(var message in messageList){
                Console.WriteLine(message);
                Console.ReadLine();
            }
        }
    }
    
}