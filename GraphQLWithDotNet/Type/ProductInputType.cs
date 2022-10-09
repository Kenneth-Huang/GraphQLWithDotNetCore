﻿using System;
using GraphQL.Types;

namespace GraphQLWithDotNet.Type
{
    public class ProductInputType: InputObjectGraphType
    {
        public ProductInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("name");
            Field<FloatGraphType>("price");

        }
    }
}

