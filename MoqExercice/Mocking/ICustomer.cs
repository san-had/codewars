namespace WareHouse
{
    public interface ICustomer
    {
        bool Purchase(IStore store, int quantity);
    }
}