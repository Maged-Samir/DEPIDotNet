using PointOfSaleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleAppTest.TestData
{
    public class ProductTestData
    {
        public static List<object[]> InvalidProducts = new List<object[]>()
        {
            new object[] { new Product() { Id = 1, Name ="" ,Price = 20 } },
            new object[] { new Product() { Id = 2, Name =null ,Price = 20 } },
            new object[] { new Product() { Id = 3, Name ="Tv" ,Price = 0 } }
        };
    }
}
