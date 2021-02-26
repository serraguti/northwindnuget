using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindNuGet.Models
{
    public class CustomerList
    {
        [JsonProperty("value")]
        public List<Customer> Customers { get; set; }
    }
}
