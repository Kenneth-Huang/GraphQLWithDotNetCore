using System;
using GraphQL;
using GraphQL.Types;
using GraphQLWithDotNet.Interfaces;
using GraphQLWithDotNet.Type;

namespace GraphQLWithDotNet.Query
{
    public class ProductQuery: ObjectGraphType
    {
        public ProductQuery(IProduct productService)
        {
            //Grammar: 
            //Field<[type]>("field name", arguments: new , QueryArguments(new QueryArgument<type> { Name = "arg name" }, resolve: resolveFunction)
            //the type after Field define what type of this field, which means what type of object will get when request this query 

            Field<ListGraphType<ProductType>>("products", resolve: context => productService.GetAllProducts());

            Field<ProductType>("product", arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                                                                            
                resolve: context => productService.GetProductById(context.GetArgument<int>("id")));

        }
    }
}

