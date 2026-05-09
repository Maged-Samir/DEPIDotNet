using PointOfSaleApp.Models;
using PointOfSaleApp.Services;
using PointOfSaleAppTest.TestData;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PointOfSaleAppTest.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public void IsValidProduct_WithValidProduct_ReturnTrue()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 1, Name = "Mobile", Price = 100 };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void IsValidProduct_WithEmptyName_ReturnFalse()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 2, Name = "", Price = 200 };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void IsValidProduct_WithZeroPrice_returnsFalse()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 2, Name = "Mobile", Price = 0 };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.False(result);

        }
        [Fact]
        public void GetAllProducts_ReturnsAllProducts()
        {
            //Arrange
            var service = new ProductService();
            service.AddProduct(new Product() { Id = 1, Name = "Printer", Price = 1000 });
            service.AddProduct(new Product() { Id = 2, Name = "Mobile", Price = 1000 });
            service.AddProduct(new Product() { Id = 3, Name = "TV", Price = 1000 });

            //Act
            var products = service.GetAllProducts();

            //Assert
            Assert.Equal(3, products.Count);
            Assert.Contains(products, p => p.Name == "Printer");

        }


        [Theory]
        [InlineData(1,"Tv",2000,true)]
        [InlineData(1,"",3000,false)]
        [InlineData(1,"Mobile",0,false)]
        public void IsValidProduct_WithDifferentValues_GetDifferentStats(int id,string name,int price ,bool expected)
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = id, Name = name, Price = price };
            //Act
           var result =  service.IsValidProduct(product);
            //Assert
            Assert.Equal(expected, result);
        }


        [Theory]
        [MemberData(nameof(ProductTestData.InvalidProducts),MemberType =typeof(ProductTestData))]
        public void IsValidProduct_WithInvalidData_ReturnsFalse(Product product)
        {
            var service = new ProductService();
            var result = service.IsValidProduct(product);
            Assert.False(result);

        }


    }
}
