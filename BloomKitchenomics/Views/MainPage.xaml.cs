using BloomKitchenomics.Models;
using BloomKitchenomics.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BloomKitchenomics
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        RecipeService _recipeApiService = new RecipeService();
        MealPlanService _mealPlanService = new MealPlanService();
        ContentService _contentService = new ContentService();
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;
        }
        protected override void OnAppearing()
        {
            ListOfRecipes.ItemsSource = _recipeApiService.GetRecipes();
            ListOfMealPlan.ItemsSource = _mealPlanService.GetMealPlan();
            ListOfSuggestedContent.ItemsSource = _contentService.GetContents();
        }
    }
}
