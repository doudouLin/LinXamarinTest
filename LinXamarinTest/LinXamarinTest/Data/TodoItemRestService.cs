using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LinXamarinTest.Model;
using System.Net.Http;
using Newtonsoft.Json;
using System.Diagnostics;
using LinXamarinTest.Models;

namespace LinXamarinTest.Data
{
    public class TodoItemRestService : IRestService
    {
        HttpClient client;
        public List<CountryModel> Items { get; private set; }

        public TodoItemRestService()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", );
        }


        public async Task<List<CountryModel>> RefreshDataAsync()
        {
            Items = new List<CountryModel>();

            var uri = Constants.RestUrl; // new Uri(string.Format(Constants.RestUrl, string.Empty));

            try
            {
                var response = await client.GetAsync(uri);

                if(response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();

                    var rr = JsonConvert.DeserializeObject<DataRs>(content);

                    if(rr != null)
                        Items = rr.RestResponse.result;
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(@"                                ERROR{0}", ex.Message);
            }

            return Items;
        }

        public Task SaveTodoItemAsync(TodoItem item, bool isNewItem)
        {
            throw new NotImplementedException();
        }


        public Task DeleteTodoItemAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
