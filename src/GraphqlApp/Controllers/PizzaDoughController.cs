using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace GraphqlApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaDoughController : ControllerBase
    {
        private readonly ILogger<PizzaDoughController> _logger;

        public PizzaDoughController(ILogger<PizzaDoughController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get All the Pizza Dough!!")]
        public async Task<IEnumerable<PizzaDough>> Get()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var db = client.GetDatabase("GraphQL_Test");
            var collection = db.GetCollection<PizzaDough>("PizzaDough");
            var pizzaDoughs = await collection.AsQueryable().ToListAsync();

            return pizzaDoughs;
        }
        
        public class PizzaDough
        {
            public ObjectId _id { get; set; }
            public string RecipeName { get; set; }
            public decimal MixTimeInMinutes { get; set; }
            public Ingredient[] Ingredients { get; set; }
        }
        
        public class Ingredient
        {
            public string IngredientName { get; set; }
            public decimal Amount { get; set; }
            public string UOM { get; set; }
        }
    }
}