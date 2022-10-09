using System;
using System.Collections.Generic;
using GraphQLWithDotNet.Interfaces;
using GraphQLWithDotNet.Models;

namespace GraphQLWithDotNet.Services
{
    public class ProductService : IProduct
    {
        private static List<Product> products = new List<Product>(){
            new Product(){Id=0, Name="Coffee", Price=4},
        new Product() { Id = 1, Name = "Bread", Price = 3},

    };

        public ProductService()
        {
        }

        public Product AddProduct(Product product)
        {
            products.Add(product);
            return product;
            //throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            if(products.Find(p=>p.Id==id)!=null)
            products.RemoveAt(id);
            //throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            return products;
            //throw new NotImplementedException();

        }

        public Product GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
            //throw new NotImplementedException();
        }

        public Product UpdateProduct(int id, Product product)
        {
            products[id] = product;
            return product;
            //throw new NotImplementedException();
        }
    }
}

