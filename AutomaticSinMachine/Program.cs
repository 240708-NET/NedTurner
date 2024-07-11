using System.Security.Cryptography;

class Program{
    static void Main(string[] args){

    Random rand = new();
    Messages messages = new();
    Write writer = new(rand,messages);

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

        Thread.Sleep(1500);
        Write.FastLineMediumPause("Press Enter To Continue");
        Console.ReadLine();
        Console.Clear();
        

        writer.PrintMessageXTimes(messages.bootMessages,3,"slow");

        Console.Clear();

        
        Write.FastLineMediumPause("Begin Judgment!");
        Console.WriteLine();


        writer.AcceptValues("Reveal Name: ");
        
        writer.AcceptValues("Enter Age: ");

        writer.AcceptValues("Favourite Colour: ");

        
        

        Console.Clear();
        writer.PrintMessageXTimes(messages.computeMessages,3,"slow");

        // Thread.Sleep(2000);

        Write.TimedWrite(". . . ",400);
    
//                                 ,.        ,.      ,.
//                                 ||        ||      ||  ()
//  ,--. ,-. ,.,-.  ,--.,.,-. ,-.  ||-.,.  ,.|| ,-.  ||-.,. ,-. ,.,-.  ,--.
// //`-'//-\\||/|| //-||||/`'//-\\ ||-'||  ||||//-\\ ||-'||//-\\||/|| ((`-'
// ||   || |||| ||||  ||||   || || ||  || /|||||| || ||  |||| |||| ||  ``.
// \\,-.\\-//|| || \\-||||   \\-|| ||  ||//||||\\-|| ||  ||\\-//|| || ,-.))
//  `--' `-' `' `'  `-,|`'    `-^-``'  `-' `'`' `-^-``'  `' `-' `' `' `--'
//                   //           
//               ,-.//          
//               `--'  ");
        Console.WriteLine(messages.completeMessages[rand.Next(messages.completeMessages.Count-1)]);

        

        Console.Write("Sin Assigned! Press To Progress!");
        Console.ReadLine();

        Console.Clear();

        Write.SlowWrite("Your Sin Is: ");
        
        Write.SlowWrite(". . . . . . . . . . . . . . . . ");
        Console.WriteLine();

        Console.WriteLine(messages.sinList[rand.Next(messages.sinList.Count-1)]);

        writer.RevealAllContents(messages.sinList);


    }
}