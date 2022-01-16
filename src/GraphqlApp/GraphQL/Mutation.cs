using GraphqlApp.Models;
using MongoDB.Driver;

namespace GraphqlApp.GraphQL;

public class Mutation
{
    private readonly IMongoDatabase _dataBase;

    public Mutation()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        _dataBase = client.GetDatabase("GraphQL_Test");
    }
    
    public async Task<bool> AddPizzaDough(PizzaDoughInput pizzaDoughInput)
    {
        var collection = _dataBase.GetCollection<PizzaDough>("PizzaDough");
        await collection.InsertOneAsync(new PizzaDough
        {
            RecipeName = pizzaDoughInput.RecipeName,
            MixTimeInMinutes = pizzaDoughInput.MixTimeInMinutes,
            Ingredients = pizzaDoughInput.Ingredients
        });

        return true;
    }

    public class PizzaDoughInput
    {
        public string RecipeName { get; set; }
        public decimal MixTimeInMinutes { get; set; }
        public Ingredient[] Ingredients { get; set; }
    }
}