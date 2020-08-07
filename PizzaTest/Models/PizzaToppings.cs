using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace PizzaTest.Models
{
    public class PizzaToppings
    {
        [JsonProperty("toppings")]
        public List<string> Toppings { get; set; }
    }

    public class TopPizzaToppings
    {
        public string Name { get; set; }
        public int Total { get; set; }
    }
}
