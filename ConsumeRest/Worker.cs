using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ModelLib.Model;
using Newtonsoft.Json;

namespace ConsumeRest
{
    class Worker
    {
        private string URI = "http://restitemjacob.azurewebsites.net/api/localitems/";
        public void Start()
        {

//            int id = Convert.ToInt32(Console.ReadLine());
//            DeleteItemAsync(id);
//
//
//            IList<Item> items = GetAllItemsAsync().Result;
//            foreach (var item in items)
//            {
//                Console.WriteLine(item.ToString());
//            }


//            
            while (true)
            {
//                try
//                {
//                    Console.WriteLine("Get One, Write ID");
//                    int id = Convert.ToInt32(Console.ReadLine());
//                    Item oneitem = GetOneItemAsync(id).Result;
//                    Console.WriteLine(oneitem.ToString());
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e);
//                    throw;
//                }
                int id = Convert.ToInt32(Console.ReadLine());
                string putItem =  Console.ReadLine();
                PutItemAsync(id, putItem);

//                try
//                {
//                    Console.WriteLine("Post item, Write json string");
//                    string postItem =  Console.ReadLine();
//
//                    PostItemAsync(postItem);
//                }
//                catch (Exception e)
//                {
//                    Console.WriteLine(e);
//                    throw;
//                }
            }
        }

        public async Task<IList<Item>> GetAllItemsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URI);
                IList<Item> cList = JsonConvert.DeserializeObject<IList<Item>>(content);
                return cList;
            }
        }

        public async Task<Item> GetOneItemAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(URI + id);
                Item item = JsonConvert.DeserializeObject<Item>(content);
                return item;
            }
        }

        public async void DeleteItemAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                await client.DeleteAsync(URI + id);
            }
        }

        public async void PostItemAsync(string jsonStr)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
                await client.PostAsync(URI, content);
            }
        }

        public async void PutItemAsync(int id, string jsonStr)
        {
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(jsonStr, Encoding.UTF8, "application/json");
                await client.PutAsync(URI + id, content);
            }
        }
    }
}
