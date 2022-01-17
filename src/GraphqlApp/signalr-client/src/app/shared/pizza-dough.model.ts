export class PizzaDoughModel {
  id: string;
  recipeName: string;
  mixTimeInMinutes: number;
  ingredients: Ingredient[];
}

export class Ingredient {
  ingredientName: string;
  amount: number;
  uom: string;
}
