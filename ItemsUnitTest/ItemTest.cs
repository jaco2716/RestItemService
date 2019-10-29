using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestItemService.Controllers;
using ModelLib.Model;

namespace ItemsUnitTest
{
    [TestClass]
    public class ItemTest
    {
        ItemsController itemsController = new ItemsController();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsNotNull(itemsController);
        }

        [TestMethod]
        public void GetOneTest()
        {
            Item testItem = itemsController.Get(1);
            Assert.IsNotNull(testItem);
            
        }
        [TestMethod]
        public void GetAllTest()
        {
            IEnumerable<Item> testItemList = itemsController.Get();
            Assert.IsNotNull(testItemList);

        }

        [TestMethod]
        public void PostTest()
        {
            itemsController.Post(new Item(999, "hej", "low", 38.2));
            Item testItem = itemsController.Get(999);
            Assert.AreEqual(new Item(999, "hej", "low", 38.2).ToString(), testItem.ToString());
        }

        [TestMethod]
        public void PutTest()
        {

        }

        [TestMethod]
        public void DeleteTest()
        {

        }
    }
}
