namespace Checkout.Types
{
    // Product structure class
    public class Product
    {
        public string Sku;
        public int Cost;
        public int Qty = 1;

        public Product(string sku, int cost)
        {
            Sku = sku;
            Cost = cost;
        }

        public void AddQty()
        {
            Qty++;
        }
    }
}
