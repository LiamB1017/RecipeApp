using System;
using System.Collections.Generic;

namespace RecipeApp
{
    
    internal class RecipeApp
    {
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public RecipeApp()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        public void AddIngredient(string name, double quantity, string unit)
        {
            Ingredients.Add(new Ingredient(name, quantity, unit));
        }

        public void AddStep(string step)
        {
            Steps.Add(step);
        }

        public void DisplayRecipe()
        {
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i]}");
            }
        }

        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        public void ResetQuantities()
        {
            // Implement code to reset quantities to original values
        }

        public void ClearRecipe()
        {
            Ingredients.Clear();
            Steps.Clear();
        }
    }

    class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }
    }
}



namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();

            // Prompt user to enter number of ingredients
            Console.Write("Enter the number of ingredients: ");
            int ingredientCount = int.Parse(Console.ReadLine());

            // Prompt user to enter ingredients
            for (int i = 0; i < ingredientCount; i++)
            {
                Console.Write($"Enter ingredient {i + 1} name: ");
                string name = Console.ReadLine();

                Console.Write($"Enter quantity for {name}: ");
                double quantity = double.Parse(Console.ReadLine());

                Console.Write($"Enter unit for {name}: ");
                string unit = Console.ReadLine();

                recipe.AddIngredient(name, quantity, unit);
            }

            // Prompt user to enter number of steps
            Console.Write("\nEnter the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            // Prompt user to enter steps
            for (int i = 0; i < stepCount; i++)
            {
                Console.Write($"Enter step {i + 1}: ");
                string step = Console.ReadLine();

                recipe.AddStep(step);
            }

            // Display the recipe
            Console.WriteLine("\nRecipe:");
            recipe.DisplayRecipe();

            // Test scaling the recipe
            Console.Write("\nEnter scaling factor (0.5 for half, 2 for double, 3 for triple): ");
            double factor = double.Parse(Console.ReadLine());
            recipe.ScaleRecipe(factor);

            // Display the scaled recipe
            Console.WriteLine("\nScaled Recipe:");
            recipe.DisplayRecipe();

            // Reset quantities
            // recipe.ResetQuantities();

            // Clear recipe
            // recipe.ClearRecipe();
        }
    }
}
