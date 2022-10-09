using System;
using GraphQL.Types;
using GraphQLWithDotNet.Models;

namespace GraphQLWithDotNet.Type
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(p => p.Id);
            Field(p => p.Name);
            Field("Price", p => p.Price);
        }
    }
}

