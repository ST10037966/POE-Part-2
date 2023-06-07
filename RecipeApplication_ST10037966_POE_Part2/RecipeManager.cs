using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApplication2._0
{
    // Recipe Manager Class
    class RecipeManager
    {
        private List<Recipe> recipes;

        public RecipeManager()
        {
            recipes = new List<Recipe>();
        }

        public void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }

        public Recipe RecipeName(string name)
        {
            return recipes.FirstOrDefault(recipe => recipe.Name == name);
        }
        //Sprts the recipes, putting them in alphabetical order
        public List<Recipe> GetSortedRecipes()
        {
            List<Recipe> sortedRecipes = new List<Recipe>(recipes);
            sortedRecipes.Sort((x, y) => string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase));
            return sortedRecipes;
        }
    }
}
//-------------------------------------------------fin.-------------------------------------------------//
//--------------------------------------------------CDC-------------------------------------------------//
