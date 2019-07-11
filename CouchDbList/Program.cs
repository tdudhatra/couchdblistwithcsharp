using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace CouchDbList
{
    class Program
    {
        static void Main(string[] args)
        {
            string couchdbURL = "http://localhost:5984/";
            string apiEndPoint = "_all_dbs";
            HttpClient httpClient = new HttpClient();
            
            string userDbUri = couchdbURL + apiEndPoint;
            var APIResponse = httpClient.GetAsync(userDbUri).Result.Content.ReadAsStringAsync();
            var result = APIResponse.Result;
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
