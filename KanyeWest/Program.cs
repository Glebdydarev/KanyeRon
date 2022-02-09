using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeWest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 5; i++)
            {




                //kanyeRest
                var kanyeURL = "https://api.kanye.rest";


                var client = new HttpClient();

                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


                Console.WriteLine($"Kanye says {kanyeQuote}");
                Console.WriteLine();




                //Ron Swanson

                var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

                var ronclient = new HttpClient();

                var ronResponse = client.GetStringAsync(ronURL).Result;

                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine($"Ron says {ronQuote}");
                Console.WriteLine();

                }
        }
    }
}
