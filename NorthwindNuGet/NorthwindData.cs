using Newtonsoft.Json;
using NorthwindNuGet.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindNuGet
{
    public class NorthwindData
    {
        public async Task<CustomerList> GetCustomersListAsync()
        {
            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";
            String url = "https://services.odata.org/V4/Northwind/Northwind.svc/Customers";
            String datajson =
                await client.DownloadStringTaskAsync(url);
            CustomerList customers =
                JsonConvert.DeserializeObject<CustomerList>(datajson);
            return customers;
        }
    }
}
