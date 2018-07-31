using Checkout.Types;
using System.Collections.Generic;

namespace CheckoutTests.ExtensionClasses
{
    internal class CheckoutExtension : Checkout.Models.Checkout
    {
        internal List<Product> GetProducts()
        {
            return ScannedProducts;
        }
    }
}
