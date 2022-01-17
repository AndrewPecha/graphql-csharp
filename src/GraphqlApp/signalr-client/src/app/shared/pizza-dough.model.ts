export class PizzaDoughModel {
  recipeName: string;
  mixTimeInMinutes: number;
  ingredients: Ingredient[];
}

export class Ingredient {
  ingredientName: string;
  amount: number;
  uom: string;
}
