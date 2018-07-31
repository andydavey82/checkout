namespace Checkout.Interfaces
{
    public interface ICheckout
    {
        void Scan(string sku);
        int GetTotal();
    }
}
