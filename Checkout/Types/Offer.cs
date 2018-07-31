// Class for offer
namespace Checkout.Types
{
    public class Offer
    {
        public Product ProductOnOffer;
        public int Quantity;
        public int OfferPrice;

        public Offer(Product product, int quantity, int price)
        {
            ProductOnOffer = product;
            Quantity = quantity;
            OfferPrice = price;
        }
    }
}
