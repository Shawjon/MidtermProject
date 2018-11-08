using System;
using MidtermProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sortProductlist_Sort_True()
        {
            //arrange 
            //List<Product> List = new List<Product>();
            Product product1 = new Product("A", Category.Starter, "A", 0);
            Product product2 = new Product("B", Category.Starter, "B", 0);
            Product product3 = new Product("H", Category.Desert, "H", 0);
            Product product4 = new Product("C", Category.Starter, "C", 0);
            Product product5 = new Product("E", Category.Main, "E", 0);
            Product product6 = new Product("F", Category.Desert, "F", 0);
            Product product7 = new Product("G", Category.Desert, "G", 0);
            Product product8 = new Product("D", Category.Main, "D", 0);
            //List.Add(product1, product2, product3, product4, product5, product6, product7, product8);
            List<Product> List = new List<Product> { product1, product2, product3, product4, product5, product6, product7, product8 };





            List<Product> List1 = new List<Product> { product1, product2, product4, product8, product5, product6, product7, product3 };



            //act
            List.Sort();

            //assert
            Assert.ReferenceEquals(List, List1);
        }
    }
}
