using System.Collections.Generic;

namespace RecipeApp
{
    internal interface IRecipe
    {
        List<Ingredient> Ingredients { get; set; }
        List<string> Steps { get; set; }

        void AddIngredient(string name, double quantity, string unit);
        void AddStep(string step);
        void ClearRecipe();
        void DisplayRecipe();
        void ResetQuantities();
        void ScaleRecipe(double factor);
    }
}