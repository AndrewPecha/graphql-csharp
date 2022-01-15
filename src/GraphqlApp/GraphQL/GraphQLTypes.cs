using GraphqlApp.Models;

namespace GraphqlApp.GraphQL;

public class GraphQLTypes
{
    public class PizzaDoughType : ObjectType<PizzaDough>
    {
        protected override void Configure(IObjectTypeDescriptor<PizzaDough> descriptor)
        {
            descriptor.Ignore(x => x._id);
        }
    }
}