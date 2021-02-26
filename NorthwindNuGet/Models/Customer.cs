using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindNuGet.Models
{
    public class Customer
    {
        [JsonProperty("CustomerID")]
        public String IdCustomer { get; set; }
        [JsonProperty("CompanyName")]
        public String Company { get; set; }
        [JsonProperty("ContactName")]
        public String Name { get; set; }
        [JsonProperty("Address")]
        public String Address { get; set; }
        [JsonProperty("City")]
        public String City { get; set; }
    }
}
