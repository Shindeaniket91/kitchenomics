using BloomKitchenomics.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloomKitchenomics.Service
{
    public class RecipeService
    {
        internal List<Recipe> GetRecipes()
        {
            List<Recipe> recipes = new List<Recipe>
            {
                new Recipe { RecipeName = "Taba ng talangka", RecipeImage = "tabangtalangka.png"},
                new Recipe { RecipeName = "Pancit Palabok", RecipeImage = "Pancitpalabok.png"},
                new Recipe { RecipeName = "Bulalo", RecipeImage = "Bulalo.png"},
                new Recipe { RecipeName = "Taba ng talangka", RecipeImage = "tabangtalangka.png"}
            };

            return recipes;
        }
    }
}
