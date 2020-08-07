using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using Newtonsoft.Json;
using PizzaTest.Models;

namespace PizzaTest.Helpers
{
    public static class JsonHelper
    {
        public static T SerializeJsonFile<T>()
        {
            using (var reader = new StreamReader(Directory.GetCurrentDirectory() + ConfigurationHelper.GetFileFullPath()))
            {
                return JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
            }
        }

        public static int GetCountByToppings(this List<string> list, string toppings)
        {
            return list.Count(e => e == toppings);
        }

        public static List<TopPizzaToppings> GetTop20PizzaToppings(this List<PizzaToppings> pizzaToppingsList)
        {
            var totalToppings = pizzaToppingsList.Select(e => e.Toppings).SelectMany(e => e).ToList();
            var listOfToppings = totalToppings.Distinct();
            return listOfToppings.Select(listOfPizzaTopping => new TopPizzaToppings {Name = listOfPizzaTopping, Total = totalToppings.GetCountByToppings(listOfPizzaTopping)})
                .OrderByDescending(e => e.Total)
                .Take(20)
                .ToList();
        }
    }
}
