using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DemoLib.Models;

namespace DemoTest.Models
{
    [TestClass]
    public class TProduct
    {
        [TestMethod]
        public void TestConstructor()
        {
            string name = "name";
            string category = "category";
            int count = 3;
            string parts = "parts";
            double price = 3.50;
            string supplier = "supplier";
            string imagePath = "imagePath";

            Product actual = new Product(name,category,count,parts,price,supplier,imagePath);

            string expectedName = name;
            string expectedCategory = category;
            int expectedCount = count;
            string expectedParts = parts;
            double expectedPrice = price;
            string expectedSupplier = supplier;
            string expectedImagePath = imagePath;

            Assert.AreEqual(expectedName, actual.Name);
            Assert.AreEqual(expectedCategory, actual.Category);
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.AreEqual(expectedParts, actual.Parts);
            Assert.AreEqual(expectedPrice, actual.Price);
            Assert.AreEqual(expectedSupplier, actual.Supplier);
            Assert.AreEqual(expectedImagePath, actual.ImagePath);
        }
    }
}
