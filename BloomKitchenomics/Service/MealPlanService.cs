using BloomKitchenomics.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloomKitchenomics.Service
{
    public class MealPlanService
    {
        internal List<MealPlan> GetMealPlan()
        {
            List<MealPlan> mealPlan = new List<MealPlan>
            {
                new MealPlan { MealName = "Bangus Sardines", MealImage = "Sardines.png", Day = "Monday"},
                new MealPlan { MealName = "Stir-Fried Tofu", MealImage = "Tofu.png", Day = "Tuesday"},
                new MealPlan { MealName = "Bangus Sardines", MealImage = "Sardines.png", Day = "Wednesday"},
                new MealPlan { MealName = "Stir-Fried Tofu", MealImage = "Tofu.png", Day = "Thursday"}
            };

            return mealPlan;
        }
    }
}
