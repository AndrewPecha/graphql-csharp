This project is created based on the instructions at
https://developer.okta.com/blog/2020/08/24/simple-graphql-csharp


simple mutation:

```graphql
addPizzaDough(
    pizzaDoughInput: {
      recipeName: "HGR"
      mixTimeInMinutes: 2.3
      ingredients: [
        { ingredientName: "water", amount: 224, uOM: "fl oz" }
        { ingredientName: "flour", amount: "102", uOM: "lbs" }
      ]
    }
  )
```