using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;

class Program
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Starting up, baybee!");

        string uri = "http://localhost:5280";

        HttpClient client = new HttpClient();

        TipService tipper = new TipService(uri,client);

        int order_id = 0;
        
        Console.Write("Enter Order Id: ");
        if(int.TryParse(Console.ReadLine(),out int toUse))
        {
            order_id = toUse;
        }

        // Get by Order Id
        var theTip = await tipper.GetTipByOrderId(order_id);
        if(theTip!= null)
        Console.WriteLine(theTip.Describe());
        else
        Console.WriteLine("No dice");

        // Create new 



    }
}