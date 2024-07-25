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

        // Get by Order Id
        var theTip = await tipper.GetTipByOrderId(80);
        if(theTip!= null)
        Console.WriteLine(theTip.Describe());
        else
        Console.WriteLine("No dice");

        // Create new 



    }
}