using System;
using GraphQLWithDotNet.Query;

namespace GraphQLWithDotNet.Schema
{
    public class ProductSchema: GraphQL.Types.Schema
    {
        public ProductSchema(ProductQuery productQuery)
        {
            Query = productQuery;
        }
    }
}

