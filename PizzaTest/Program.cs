using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using PizzaTest.Helpers;
using PizzaTest.Models;

namespace PizzaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var top20Toppings = JsonHelper.SerializeJsonFile<List<PizzaToppings>>().GetTop20PizzaToppings();
            int index = 1;
            foreach (var toppings in top20Toppings)
            {
                Console.WriteLine($"#{index}. \t Name: {toppings.Name}, Count: {toppings.Total}");
                index++;
            }

            Console.ReadKey();
        }
    }
}
