using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MaitlandCodes.DataWarehouse.OSRS.Api
{
    public class OSRSApiClient
    {
        private readonly HttpClient httpClient;

        public OSRSApiClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
    }
}
