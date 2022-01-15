using MongoDB.Bson;

namespace GraphqlApp.Models;

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