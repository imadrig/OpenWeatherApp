using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace OpenWeatherApp
{
    public class Program
    {
        static void Main(string[] args)
        {
           var client = new HttpClient();

            var key = "7c7e15abba05455a978550ec598cb8d8";

            

            var weatherAppURL = $"https://api.openweathermap.org/data/2.5/weather?lat=38.89&lon=-77.03&appid={key}";
     
            var response = client.GetStringAsync(weatherAppURL).Result;  

            Console.WriteLine(response);

            JObject formatted = JObject.Parse(response);
            //var temp = formatted["list"][0]["main"]["temp"];
            Console.WriteLine(temp);

        }
    }
}