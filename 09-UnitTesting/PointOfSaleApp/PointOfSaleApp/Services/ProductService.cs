using PointOfSaleApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PointOfSaleApp.Services
{
    public class ProductService
    {
        List<Product> _products = new List<Product>();

        public bool IsValidProduct(Product product)
        {
            if (string.IsNullOrEmpty(product.Name))
                return false;

            if (product.Price <= 0)
                return false;

            return true;
        }

        //Crud
        public void AddProduct(Product product)
        {
            if (!IsValidProduct(product))
                throw new ArgumentException("Invalid Product");

            _products.Add(product);
        }
        public Product GetProductById(int id)
        {
            return _products.SingleOrDefault(p => p.Id == id);
        }
        public List<Product> GetAllProducts()
        {
            return _products;
        }
        public bool UpdateProduct(Product product)
        {
            var existingProduct = GetProductById(product.Id);
            if (existingProduct == null) return false;

            if (!IsValidProduct(product))
                throw new ArgumentException("Invalid Product");

            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;

            return true;
        }

        public bool RemoveProduct(int id)
        {
            var product = GetProductById(id);
            if (product == null) return false;
            return _products.Remove(product);
        }

    }
}
