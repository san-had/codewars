using Moq;
using NUnit.Framework;
using WareHouse;

namespace WareHouseTest
{
    public class UnitTestLondon
    {
        [Test]
        public void Purchase_succeeds_when_enough_inventory()
        {
            var storeMock = new Mock<IStore>();
            storeMock.Setup(store => store.HasEnoughInventory(5)).Returns(true);
            var customer = new Customer();

            bool success = customer.Purchase(storeMock.Object, 5);

            Assert.IsTrue(success);
            storeMock.Verify(store => store.RemoveInventory(5), Times.Once);
        }

        [Test]
        public void Purchase_fails_when_not_enough_inventory()
        {
            var storeMock = new Mock<IStore>();
            storeMock.Setup(store => store.HasEnoughInventory(10)).Returns(false);
            var customer = new Customer();

            bool success = customer.Purchase(storeMock.Object, 15);

            Assert.IsFalse(success);
            storeMock.Verify(store => store.RemoveInventory(15), Times.Never);
        }
    }
}