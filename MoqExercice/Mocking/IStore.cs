namespace WareHouse
{
    public interface IStore
    {
        int Inventory { get; set; }

        void AddInventory(int quantity);

        int GetInventory();

        bool HasEnoughInventory(int quantity);

        void RemoveInventory(int quantity);
    }
}