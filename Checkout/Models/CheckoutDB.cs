using Checkout.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout.Models
{
    // This class simulates DB to keep solution simple
    // Usually data would be stored in db, but for this purpose and to keep simply
    // this class can be extended to actually link to any DB of your choice
    internal class CheckoutDB
    {
        private readonly List<Product> _products;
        private readonly List<Offer> _offers;

        // This used to create products and offers
        public CheckoutDB()
        {
            _products = new List<Product>
            {
                new Product("A", 50),
                new Product("B", 30),
                new Product("C", 20),
                new Product("D", 15)
            };

            _offers = new List<Offer>
            {
                new Offer(_products.First(x => x.Sku == "A"), 3, 120),
                new Offer(_products.First(x => x.Sku == "B"), 2, 45)
            };
        }

        public Product FindProductBySku(string sku)
        {
            return _products.FirstOrDefault(x => sku.Equals(x.Sku, StringComparison.CurrentCultureIgnoreCase));
        }

        public Offer GetProductOfferBySku(string sku)
        {
            return _offers.FirstOrDefault(x => sku.Equals(x.ProductOnOffer.Sku, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
