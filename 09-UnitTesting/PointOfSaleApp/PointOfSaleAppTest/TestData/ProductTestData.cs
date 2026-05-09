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
          new object[] {new Product(){ Id = 1 ,Name="",Price=200} },
          new object[] {new Product(){ Id = 1 ,Name="TV",Price=0} },
          new object[] {new Product(){ Id = 1 ,Name="Printer",Price=-2} },

        };

    }
}
