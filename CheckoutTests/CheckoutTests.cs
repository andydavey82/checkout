using System;
using CheckoutTests.ExtensionClasses;
using NUnit.Framework;

namespace CheckoutTests
{
    [TestFixture]
    public class CheckoutTests
    {
        private CheckoutExtension checkout;

        [SetUp]
        public void Setup()
        {
            checkout = new CheckoutExtension();
        }

        [Test]
        public void TestScan()
        {
            // arrange
            // act
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("B");
            checkout.Scan("C");
            checkout.Scan("D");
            // assert
            var scannedProducts = checkout.GetProducts();
            Assert.AreEqual(4, scannedProducts.Count);
            Assert.AreEqual(2, scannedProducts.Find(x => x.Sku.Equals("A", StringComparison.CurrentCultureIgnoreCase)).Qty);
            Assert.AreEqual(1, scannedProducts.Find(x => x.Sku.Equals("B", StringComparison.CurrentCultureIgnoreCase)).Qty);
            Assert.AreEqual(1, scannedProducts.Find(x => x.Sku.Equals("C", StringComparison.CurrentCultureIgnoreCase)).Qty);
            Assert.AreEqual(1, scannedProducts.Find(x => x.Sku.Equals("D", StringComparison.CurrentCultureIgnoreCase)).Qty);
            Assert.AreEqual("D", checkout.GetLastScanned().Sku);
        }

        [Test]
        public void TestGetTotalOfferA()
        {
            // arrange
            //var checkout = new Checkout.Models.Checkout();
            // act and assert to determine offer
            checkout.Scan("A");
            Assert.AreEqual(50, checkout.GetTotal());
            checkout.Scan("A");
            Assert.AreEqual(100, checkout.GetTotal());
            checkout.Scan("A");
            Assert.AreEqual(120, checkout.GetTotal());
            checkout.Scan("A");
            Assert.AreEqual(170, checkout.GetTotal());
        }

        [Test]
        public void TestGetTotalOfferB()
        {
            // arrange
            //var checkout = new Checkout.Models.Checkout();
            // act and assert to determine offer
            checkout.Scan("B");
            Assert.AreEqual(30, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(45, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(75, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(90, checkout.GetTotal());
        }

        [Test]
        public void TestGetTotalOfferAB()
        {
            // arrange
            //var checkout = new Checkout.Models.Checkout();
            // act and assert to determine offer
            checkout.Scan("A");
            Assert.AreEqual(50, checkout.GetTotal());
            checkout.Scan("A");
            Assert.AreEqual(100, checkout.GetTotal());
            checkout.Scan("A");
            Assert.AreEqual(120, checkout.GetTotal());
            checkout.Scan("A");
            Assert.AreEqual(170, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(200, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(215, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(245, checkout.GetTotal());
            checkout.Scan("B");
            Assert.AreEqual(260, checkout.GetTotal());
        }
    }
}
