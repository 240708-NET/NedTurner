using System.Security.Cryptography;

class Program{
    static void Main(string[] args){

    Sins sins = new Sins();
    Write writer = new Write();

    Console.WriteLine(@"
    
    _         _                        _   _        ____  _       
   / \  _   _| |_ ___  _ __ ___   __ _| |_(_) ___  / ___|(_)_ __  
  / _ \| | | | __/ _ \| '_ ` _ \ / _` | __| |/ __| \___ \| | '_ \ 
 / ___ \ |_| | || (_) | | | | | | (_| | |_| | (__   ___) | | | | |
/_/  _\_\__,_|\__\___/|_|_|_| |_|\__,_|\__|_|\___| |____/|_|_| |_|
            |  \/  | __ _  ___| |__ (_)_ __   ___                             
            | |\/| |/ _` |/ __| '_ \| | '_ \ / _ \                            
            | |  | | (_| | (__| | | | | | | |  __/                            
            |_|  |_|\__,_|\___|_| |_|_|_| |_|\___|   
            
            
            ");

        Thread.Sleep(200);
        writer.FastLineMediumPause("Press Enter To Continue");
        Console.ReadLine();
        Console.Clear();
        

        writer.PrintThreeMessages(writer.bootMessages);

        Console.Clear();

        
        writer.FastLineMediumPause("Begin Judgment!");

        writer.SlowWrite("Reveal Name: ");
        string name = Console.ReadLine();
        writer.FastLineMediumPause("Yikes");
        

        writer.SlowWrite("Enter Age: ");
        string age = Console.ReadLine();
        writer.FastLineMediumPause("Sorry about that");

        
        writer.SlowWrite("Favourite Colour: ");
        string colour = Console.ReadLine();
        writer.FastLineMediumPause("Ew");
        
        

        Console.Clear();
        writer.PrintThreeMessages(writer.computeMessages);

        // Thread.Sleep(2000);

        writer.TimedWrite(". . . . .",400);

        Console.WriteLine(@"
        
                                ,.        ,.      ,.
                                ||        ||      ||  ()
 ,--. ,-. ,.,-.  ,--.,.,-. ,-.  ||-.,.  ,.|| ,-.  ||-.,. ,-. ,.,-.  ,--.
//`-'//-\\||/|| //-||||/`'//-\\ ||-'||  ||||//-\\ ||-'||//-\\||/|| ((`-'
||   || |||| ||||  ||||   || || ||  || /|||||| || ||  |||| |||| ||  ``.
\\,-.\\-//|| || \\-||||   \\-|| ||  ||//||||\\-|| ||  ||\\-//|| || ,-.))
 `--' `-' `' `'  `-,|`'    `-^-``'  `-' `'`' `-^-``'  `' `-' `' `' `--'
                  //           
              ,-.//          
              `--'  ");
        

        Console.Write("Sin Assigned! Press To Progress!");
        Console.ReadLine();

        Console.Clear();

        writer.SlowWrite("Your Sin Is: ");
        
        
        Thread.Sleep(2000);
        
        Thread.Sleep(1500);

        writer.PrintSin();

        writer.RevealSins();


    }
}