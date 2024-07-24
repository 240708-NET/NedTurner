using System;
using System.Net.Http;
using System.Text.Json;

using HTTPConsumer.Models;

namespace HTTPConsumer.Con
{
    class Program
    {
        public static async Task Main( string[] args )
        {
            Console.WriteLine( "Http Client is starting..." );

            string uri = "https://jsonplaceholder.typicode.com/";

            HttpClient client = new HttpClient();

            string comments = await client.GetStringAsync(uri + "comments/");

            // Console.WriteLine( response );

            List<Comment>? postsList = JsonSerializer.Deserialize<List<Comment>>(comments);

            foreach ( var i in postsList )
                Console.WriteLine( i.id + ": " + i.body );

        }
    }
}