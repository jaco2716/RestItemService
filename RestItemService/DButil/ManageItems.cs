using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelLib.Model;

namespace RestItemService.DButil
{
    public class ManageItems
    {

        private const string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public IEnumerable<Item> Get()
        {
            return new List<Item>();
        }

        public Item Get(int id)
        {
            return new Item();
        }

        public void Post(Item value)
        {

        }

        public void Put(int id, Item value)
        {

        }

        public void Delete(int id)
        {

        }
        public IEnumerable<Item> GetFromSubstring(String substring)
        {
            return new List<Item>();
        }
        public IEnumerable<Item> GetFromQuality(String substring)
        {
            return new List<Item>();
        }
        public IEnumerable<Item> GetWithFilter([FromQuery] FilterItem filter)
        {
            return new List<Item>();
        }
    }
}
