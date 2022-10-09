using System;
using System.Collections.Generic;
using GraphQLWithDotNet.Models;

namespace GraphQLWithDotNet.Interfaces
{
    public interface IProduct
    {
        List<Product> GetAllProducts();
        Product AddProduct(Product product);
        Product UpdateProduct(int id, Product product);
        void DeleteProduct(int id);

        Product GetProductById(int id);

    }
}

