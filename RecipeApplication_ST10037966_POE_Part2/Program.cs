using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication2._0
{
    //Start of application
    internal class Program
    {
        static void Main(string[] args)
        {
            RecipeManager recipeManager = new RecipeManager();

            while (true)
            {
                //Displays the menu for the user to input their choice
                Console.Title = "Cameron's Recipe Application";
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n*********************************************");
                Console.WriteLine("Type an input of '1' to enter recipe details");
                Console.WriteLine("Type an input of '2' to display recipe");
                Console.WriteLine("Type an input of '3' to scale recipe");
                Console.WriteLine("Type an input of '4' to reset quantities");
                Console.WriteLine("Type an input of '5' to clear recipe");
                Console.WriteLine("Type an input of '6' to calculate calories");
                Console.WriteLine("Type an input of '7' to exit");
                Console.WriteLine("*********************************************\n");

                //Functions of the menu
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the recipe: ");
                        string recipeName = Console.ReadLine();
                        Recipe recipe = new Recipe();
                        recipe.Name = recipeName;
                        recipe.RecipeDetails();
                        recipeManager.AddRecipe(recipe);
                        break;
                    case "2":
                        List<Recipe> sortedRecipes = recipeManager.GetSortedRecipes();
                        Console.WriteLine("List of Recipes:");
                        foreach (Recipe r in sortedRecipes)
                        {
                            Console.WriteLine($"- {r.Name}");
                        }
                        Console.Write("Enter recipe name to display: ");
                        string RecipeName = Console.ReadLine();
                        Recipe recipeToDisplay = recipeManager.RecipeName(RecipeName);
                        if (recipeToDisplay != null)
                        {
                            recipeToDisplay.DisplayRecipe();
                        }
                        else
                        {
                            Console.WriteLine("There is no Recipe with the name you inserted.");
                        }
                        break;
                    case "3":
                        Console.Write("Enter the name of the recipe to scale: ");
                        string recipeToScale = Console.ReadLine();
                        Recipe scaleRecipe = recipeManager.RecipeName(recipeToScale);
                        if (scaleRecipe != null)
                        {
                            Console.Write("Enter scaling factor (0.5, 2, or 3): ");
                            double factor = double.Parse(Console.ReadLine());
                            scaleRecipe.ScaleRecipe(factor);
                        }
                        else
                            Console.WriteLine("There is no Recipe with the name you inserted.");
                        break;
                    case "4":
                        Console.Write("Enter the name of the recipe to reset quantities: ");
                        string recipeToReset = Console.ReadLine();
                        Recipe resetRecipe = recipeManager.RecipeName(recipeToReset);
                        if (resetRecipe != null)
                            resetRecipe.ResetQuantities();
                        else
                            Console.WriteLine("There is no Recipe with the name you inserted.");
                        break;
                    case "5":
                        Console.Write("Enter the name of the recipe to clear: ");
                        string recipeToClear = Console.ReadLine();
                        Recipe clearRecipe = recipeManager.RecipeName(recipeToClear);
                        if (clearRecipe != null)
                            clearRecipe.ClearRecipe();
                        else
                            Console.WriteLine("There is no Recipe with the name you inserted.");
                        break;
                    case "6":
                        Console.Write("Enter recipe name to calculate total calories: ");
                        string recipeToCalculateCaloriesName = Console.ReadLine();
                        Recipe recipeToCalculateCaloriesObj = recipeManager.RecipeName(recipeToCalculateCaloriesName);
                        if (recipeToCalculateCaloriesObj != null)
                        {
                            int totalCalories = recipeToCalculateCaloriesObj.CalorieCount();
                            Console.WriteLine($"Total calories: {totalCalories}");
                        }
                        else
                        {
                            Console.WriteLine("There is no Recipe with the name you inserted.");
                        }
                        break;
                    case "7":
                        Console.Beep();
                        Console.WriteLine("Thank you for using our application...Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter the number of which function you would like to choose.");
                        break;

                        //End of application
                }
            }
        }
    }
}
//-------------------------------------------------fin.-------------------------------------------------//
//--------------------------------------------------CDC-------------------------------------------------//
