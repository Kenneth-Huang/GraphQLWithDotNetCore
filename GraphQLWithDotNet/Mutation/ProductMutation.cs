using System;
using GraphQL;
using GraphQL.Types;
using GraphQLWithDotNet.Interfaces;
using GraphQLWithDotNet.Models;
using GraphQLWithDotNet.Type;

namespace GraphQLWithDotNet.Mutation
{
    public class ProductMutation: ObjectGraphType
    {
        public ProductMutation(IProduct productService)
        {
            //Field<[return type]>
            Field<ProductType>("createProduct", arguments: new QueryArguments(new QueryArgument<ProductInputType> { Name = "product" }),
              resolve: context => productService.AddProduct(context.GetArgument<Product>("product")));

            Field<ProductType>("updateProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" },
                new QueryArgument<ProductInputType> { Name = "product" }),
              resolve: context => productService.UpdateProduct(context.GetArgument<int>("id"), context.GetArgument<Product>("product")));

            Field<StringGraphType>("deleteProduct", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
              resolve: context => {
                  var productId = context.GetArgument<int>("id");
                  productService.DeleteProduct(productId);
                  return "The product of" + productId + "has been deleted";
                  });
        }
    }
}

