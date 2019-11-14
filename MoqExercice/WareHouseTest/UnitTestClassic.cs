using NUnit.Framework;
using WareHouse;

namespace WareHouseTest
{
    public class UnitTestClassic
    {
        [Test]
        public void Purchase_succeeds_when_enough_inventory()
        {
            //Arrange
            var store = new Store();
            store.AddInventory(10);
            var customer = new Customer();

            //Act
            bool success = customer.Purchase(store, 5);

            //Assert
            Assert.True(success);
            Assert.AreEqual(5, store.GetInventory());
        }

        [Test]
        public void Purchase_fails_when_not_enough_inventory()
        {
            //Arrange
            var store = new Store();
            store.AddInventory(10);
            var customer = new Customer();

            //Act
            bool success = customer.Purchase(store, 15);

            //Assert
            Assert.False(success);
            Assert.AreEqual(10, store.GetInventory());
        }
    }
}