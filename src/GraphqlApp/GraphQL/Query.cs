using GraphqlApp.Models;
using HotChocolate.Data;
using MongoDB.Driver;

namespace GraphqlApp.GraphQL;

public class Query
{
    private readonly IMongoDatabase _dataBase;

    public Query()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _dataBase = client.GetDatabase("GraphQL_Test");
    }
    
    [UseFiltering(typeof(GraphQLTypes.PizzaDoughFilterType))]
    public IQueryable<PizzaDough> PizzaDoughs => _dataBase.GetCollection<PizzaDough>("PizzaDough").AsQueryable();
}