using GraphqlApp.Models;
using HotChocolate.Data.Filters;

namespace GraphqlApp.GraphQL;

public class GraphQLTypes
{
    public class PizzaDoughType : ObjectType<PizzaDough>
    {
        protected override void Configure(IObjectTypeDescriptor<PizzaDough> descriptor)
        {
            //leaving this here as an example of additional configuration
            // descriptor.Ignore(x => x._id);
        }
    }
    
    public class PizzaDoughFilterType : FilterInputType<PizzaDough>
    {
        protected override void Configure(IFilterInputTypeDescriptor<PizzaDough> descriptor)
        {
            //leaving this here as an example of additional configuration
            // descriptor.Ignore(x => x._id);
        }
    }
}