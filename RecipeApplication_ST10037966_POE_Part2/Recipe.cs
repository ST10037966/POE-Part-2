using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication2._0
{
    // Recipe Class
    class Recipe
    {
        //The properties of the recipe
        public string Name { get; set; }
        private List<Ingredient> ingredients;
        private string[] steps;

        public Recipe()
        {
            ingredients = new List<Ingredient>();
            steps = new string[0];
        }
        //The console prompts the user to enter the number of ingredients in the recipe and stores it as an integer
        public void RecipeDetails()
        {
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

            ingredients.Clear();

            //Gets the user to enter the details of each ingredient
            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient #{i + 1}: ");

                Ingredient ingredient = new Ingredient();

                Console.Write("Name: ");
                ingredient.Name = Console.ReadLine();
                Console.Write("Quantity (just the number): ");
                ingredient.Quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of measurement: ");
                ingredient.Unit = Console.ReadLine();
                Console.Write("Calories: ");
                ingredient.Calories = int.Parse(Console.ReadLine());
                Console.Write("Food Group (e.g Dairy, Protein, Fruit & Veg): ");
                ingredient.FoodGroup = Console.ReadLine();

                ingredients.Add(ingredient);
            }
            //Prompts the user for the number of steps in the recipe
            Console.Write("Enter the number of steps for your recipe: ");
            int numSteps = int.Parse(Console.ReadLine());

            steps = new string[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.Write($"Enter step number {i + 1}: ");
                steps[i] = Console.ReadLine();
            }
        }
        //Displays the recipe with the ingredients, and steps
        public void DisplayRecipe()
        {
            Console.WriteLine("The Ingredients and Steps for your recipe: ");
            Console.WriteLine("Ingredients: ");

            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} of {ingredient.Name} ({ingredient.Calories} calories, Food Group: {ingredient.FoodGroup}) ");
            }

            Console.WriteLine("Steps:");

            foreach (string step in steps)
            {
                Console.WriteLine($"- {step}");
            }

            double totalCalories = CalorieCount();
            Console.WriteLine($"Total Calories: {totalCalories}");

            if (totalCalories > 300)
            {
                Console.WriteLine("Just a warning that the calories for your recipe exceed 300!" +
                    "\n What a colorie is, is the energy in what you eat or drink" +
                    "\n A meal with 300+ calories could give you a surplus of energy.");
            }
        }
        //This method will multiply all the ingredients by the scaling factor
        public void ScaleRecipe(double factor)
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
        //Method to count the calories - adds the calories up
        public int CalorieCount()
        {
            int totalCalories = 0;
            foreach (Ingredient ingredient in ingredients)
            {
                totalCalories += ingredient.Calories;
            }
            return totalCalories;
        }
        //Method to reset the ingredient quantities to the original value
        public void ResetQuantities()
        {
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.Quantity /= 2;
            }
        }
        //Clears the recipe
        public void ClearRecipe()
        {
            ingredients.Clear();
            steps = new string[0];
        }
    }
}
//-------------------------------------------------fin.-------------------------------------------------//
//--------------------------------------------------CDC-------------------------------------------------//
