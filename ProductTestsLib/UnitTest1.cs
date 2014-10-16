using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;
using ProductAdapterLib;

namespace ProductTestsLib
{
    [TestClass]
    public class UnitTest1
    {
        IProduct product;
        IProduct expectedProduct = new Product() { BarCode = "ABC123", Title = "Product", UnitPrice = 123 };

        [TestMethod]
        public void ProductTest()
        {
            product = new Product() { BarCode = "ABC123", Title = "Product", UnitPrice = 123 };
            Assert.AreEqual(expectedProduct.BarCode, product.BarCode);
            Assert.AreEqual(expectedProduct.Title, product.Title);
            Assert.AreEqual(expectedProduct.UnitPrice, product.UnitPrice);
        }
        
        [TestMethod]
        public void SomeExternalVendorProductTest()
        {
            SomeExternalVendorProduct p = new SomeExternalVendorProduct() { Description = "Product", EANCode = "ABC123", PricePerUnit = 123 };
            product = new SomeExternalVendorProductAdapter(p);
            Assert.AreEqual(expectedProduct.BarCode, product.BarCode);
            Assert.AreEqual(expectedProduct.Title, product.Title);
            Assert.AreEqual(expectedProduct.UnitPrice, product.UnitPrice);
        }
    }
}
