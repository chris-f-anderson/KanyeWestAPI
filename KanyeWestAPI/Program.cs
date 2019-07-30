using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;


namespace KanyeWestAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.kanye.rest/";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            string joke2 = JObject.Parse(response).GetValue("quote").ToString();

            Console.WriteLine(joke2);
        }
    }
}
