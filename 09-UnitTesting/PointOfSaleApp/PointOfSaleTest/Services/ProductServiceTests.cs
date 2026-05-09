using PointOfSaleApp.Models;
using PointOfSaleApp.Services;
using PointOfSaleAppTest.TestData;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleAppTest.Services
{
    public class ProductServiceTests
    {
        [Fact]
        public void IsValidProduct_WithValidParamters_ReturnsTrue()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 1, Name = "TV", Price = 2000 };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void IsValidProduct_WithEmptyName_ReturnsFalse()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 1, Name = "", Price = 0 };
            //Act
           var result = service.IsValidProduct(product);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void IsValidProduct_WithZeroPrice_ReturnFalse()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 1, Name = "Mobile", Price = 0 };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void IsValidProduct_WithNegativePrice_ReturnFalse()
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = 1, Name = "Mobile", Price = -1 };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void GetAllProducts_ReturnAllProducts()
        {
            //Arrange 
            var service = new ProductService();
            service.AddProduct(new Product() { Id = 1, Name = "Tv", Price = 1000 });
            service.AddProduct(new Product() { Id = 2, Name = "Mobile", Price = 2000 });
            //Act
            var products = service.GetAllProducts();
            //Assert
            Assert.Equal(2, products.Count);
            Assert.Contains(products, product => product.Name == "Tv");
        }

        [Theory]
        [InlineData(1,"Mobile",2000,true)]
        [InlineData(2,"",3000,false)]
        [InlineData(3,null,4000,false)]
        [InlineData(4,"Tv",0,false)]
        [InlineData(5,"Mobile",-1,false)]
        public void IsValidProduct_WithDifferentValues_ReturnsDifferentStats(int id, string name ,int price,bool expectedResult)
        {
            //Arrange
            var service = new ProductService();
            var product = new Product() { Id = id, Name = name, Price = price };
            //Act
            var result = service.IsValidProduct(product);
            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData(nameof(ProductTestData.InvalidProducts),MemberType = typeof(ProductTestData))]
        public void IsValidProduct_WithInvalidProducts_ReturnFalse(Product product)
        {
            //Arrange
            var service = new ProductService();
            //Act
            var result = service.IsValidProduct(product);
           //Assert
           Assert.False(result);
        }


    }


}
