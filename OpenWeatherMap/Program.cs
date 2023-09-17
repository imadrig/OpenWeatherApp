using Newtonsoft.Json;
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
            var city = "Paris";


            var weatherAppURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={key}";
            var response = client.GetStringAsync(weatherAppURL).Result;

            var weatherData = JObject.Parse(response);


            var country = weatherData["sys"]["country"].ToString();
            var temp = (double)weatherData["main"]["temp"];
            var feelsLike = (double)weatherData["main"]["feels_like"];
            var mainWeatherDescription = weatherData["weather"];


            Console.WriteLine($"The current temperature in {city}, {country} is:");
            Console.WriteLine($"{temp} \u00B0F");
            Console.WriteLine($"Feels like: {feelsLike} \u00B0F");
            Console.WriteLine(mainWeatherDescription);
            

        }
    }
}