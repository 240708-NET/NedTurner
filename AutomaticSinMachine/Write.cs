class Write(Random rando, Messages messages, UserFate user)
{

    readonly Random rand = rando;
    readonly Messages messages = messages;

    UserFate user = user;

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

    public void PrintSassyMessage(){
        int toChoose = rand.Next(this.messages.sassMessages.Count-1);
            SlowLineBriefPause(this.messages.sassMessages[toChoose]);
            this.messages.sassMessages.Remove(this.messages.sassMessages[toChoose]);
    }

    public string AcceptValues(string requestValueMessage){
        
        SlowWrite(requestValueMessage);
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string readValue = Console.ReadLine();
        // ensure that the value entered was not null
        readValue = CheckIfVoid(requestValueMessage, readValue);
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        Thread.Sleep(500);
        PrintMessageXTimes(messages.sassMessages,1,"fast");
        Console.WriteLine();
        return readValue;
    }

    public string CheckIfVoid(string requestValueMessage, string readValue){
        int count=0;
        while(string.IsNullOrEmpty(readValue)){
            if(count==0){
                SlowWrite($"Really, {requestValueMessage}");
            }else if (count==1){
                SlowWrite($"No, Seriously, {requestValueMessage}");
            }else if (count==2){
                SlowWrite($"No, I Mean It, {requestValueMessage}");
            }else if (count==3){
                SlowWrite($"Last Chance, {requestValueMessage}");
            }else{
                SlowWrite($"You asked for it");
                Thread.Sleep(500);
                Console.WriteLine();
                return " ";
            }
            count++;
                #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            readValue = Console.ReadLine();
                #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

        }
        return readValue;
    }

    public int AcquireAge(string ageString){
        ageString.Trim();
        if(Int32.TryParse(ageString,out int extractedAge)){
            return extractedAge;
        }
        return 0;
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