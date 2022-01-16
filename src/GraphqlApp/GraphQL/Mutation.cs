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
    
    public async Task<bool> AddPizzaDough(PizzaDoughAddInput input)
    {
        var collection = _dataBase.GetCollection<PizzaDough>("PizzaDough");
        await collection.InsertOneAsync(new PizzaDough
        {
            RecipeName = input.RecipeName,
            MixTimeInMinutes = input.MixTimeInMinutes,
            Ingredients = input.Ingredients
        });

        return true;
    }
    
    public async Task<bool> UpdatePizzaDough(PizzaDoughUpdateInput input)
    {
        var collection = _dataBase.GetCollection<PizzaDough>("PizzaDough");
        await collection
            .ReplaceOneAsync(x => x.Id == input.Id, new PizzaDough
            {
                Id = input.Id,
                RecipeName = input.RecipeName,
                MixTimeInMinutes = input.MixTimeInMinutes,
                Ingredients = input.Ingredients
            });

        return true;
    }

    public class PizzaDoughUpdateInput : PizzaDoughAddInput
    {
        public string Id { get; set; }
    }
    
    public class PizzaDoughAddInput
    {
        public string RecipeName { get; set; }
        public decimal MixTimeInMinutes { get; set; }
        public Ingredient[] Ingredients { get; set; }
    }
}