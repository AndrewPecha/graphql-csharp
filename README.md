This project is created based on the instructions at
https://developer.okta.com/blog/2020/08/24/simple-graphql-csharp


simple mutations:

```graphql
addPizzaDough(
    input: {
      recipeName: "HGR"
      mixTimeInMinutes: 2.3
      ingredients: [
        { ingredientName: "water", amount: 224, uOM: "fl oz" }
        { ingredientName: "flour", amount: "102", uOM: "lbs" }
      ]
    }
  )
  
updatePizzaDough(
    input: {
      id: "61e3c591c458e226b08b4a47"
      recipeName: "HGRX"
      mixTimeInMinutes: 6.9
      ingredients: [
        { ingredientName: "honey", amount: 14, uOM: "tbsp" }
        { ingredientName: "milk", amount: 25, uOM: "gallons" }
      ]
    }
  )
```