namespace WareHouse
{
    public class Customer : ICustomer
    {
        public bool Purchase(IStore store, int quantity)
        {
            bool isSuccess = false;

            if (store.HasEnoughInventory(quantity))
            {
                store.RemoveInventory(quantity);
                isSuccess = true;
            }

            return isSuccess;
        }
    }
}