using Checkout.Interfaces;
using Checkout.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkout.Models
{
    public class Checkout : ICheckout, IScanned
    {
        private CheckoutDB CheckoutDB;
        protected List<Product> ScannedProducts = new List<Product>();
        private Product LastScanned = null;

        public Checkout()
        {
            // sets up fake DB this would usually be passed in using dependency injection
            CheckoutDB = new CheckoutDB();
        }

        public Product GetLastScanned()
        {
            // returns last scanned to update visual list
            return LastScanned;
        }

        public int GetTotal()
        {
            // total starts off as 0
            var total = 0;
            // go through each product
            foreach(var product in ScannedProducts)
            {
                // check to see if there are any offers available stored in DB (this case fake db for simplicty)
                var offer = CheckoutDB.GetProductOfferBySku(product.Sku);
                if(offer == null)
                {
                    // if no offers just calculate total as normal
                    total += (product.Cost * product.Qty);
                }else
                {
                    // find out number of quantities that meets the offer
                    var offersQty = product.Qty / offer.Quantity;
                    // get remaining number that is calculated normally
                    var nonOfferQty = product.Qty % offer.Quantity;

                    // calculate total of non offer quanties as normal
                    total += (product.Cost * nonOfferQty);
                    // calculate the total quanties with offer price
                    total += (offersQty * offer.OfferPrice);
                }
            }
            // returns total
            return total;
        }

        public void Scan(string sku)
        {
            // Find product by ski and assign to LastScanned
            LastScanned = CheckoutDB.FindProductBySku(sku);
            // if product is found
            if(LastScanned != null)
            {
                // has current scanned product been added to list
                var added = false;
                // loop through scanned products to see if product has been scanned before
                foreach(var product in ScannedProducts)
                {
                    // if product has been scanned before mark as added 
                    if(product.Sku.Equals(sku, StringComparison.CurrentCultureIgnoreCase))
                    {
                        // updates quantity by 1
                        product.AddQty();
                        // mark as added
                        added = true;
                    }
                }
                // if still not added then add product to scanned list
                if(!added)
                {
                    ScannedProducts.Add(LastScanned);
                }
            }
        }
    }
}
