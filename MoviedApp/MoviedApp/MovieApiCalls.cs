using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.TMDb;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoviedApp
{
    class MovieApiCalls
    {
        private string apiKey;
        private ServiceClient client;

        public MovieApiCalls(string apiKey)
        {
            this.apiKey = apiKey;
            client = new ServiceClient(apiKey);
        }

        static async Task Sample(CancellationToken cancellationToken)
        {
            
        }
}
