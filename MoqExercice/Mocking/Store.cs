namespace WareHouse
{
    public class Store : IStore
    {
        public int Inventory { get; set; }

        public void AddInventory(int quantity)
        {
            Inventory += quantity;
        }

        public int GetInventory()
        {
            return Inventory;
        }

        public bool HasEnoughInventory(int quantity)
        {
            var isEnough = Inventory >= quantity;
            return isEnough;
        }

        public void RemoveInventory(int quantity)
        {
            Inventory -= quantity;
        }
    }
}