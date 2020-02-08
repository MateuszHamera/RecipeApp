using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.ViewModel
{
    class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            
            AddProduct = new AddProductViewModel();
            AddRecipe = new AddRecipeViewModel();
        }

        public LoadRecipesFromDataBaseViewModel LoadRecipesFromDataBase { get; set; }
        public AddProductViewModel AddProduct { get; }
        public AddRecipeViewModel AddRecipe { get; }


        
    }
}
