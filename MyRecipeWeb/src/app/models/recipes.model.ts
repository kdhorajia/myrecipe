export class RecipeModel {
    recipeId: number;
    customerId: number;
    categoryId: number;
    categoryName: string;
    instruction: string;
    recipeIngredients: RecipeIngredientModel[];
    constructor(public name: string, public description: string, public authorName: string, public imageUrl: string) { }
}

export class RecipeIngredientModel {
    recipeIngredientId: number;
    ingredientId: number;
    ingredientName: string;
    recipeId: number;
    quantity: number | null;
    unit: string;
    preparation: string;
}