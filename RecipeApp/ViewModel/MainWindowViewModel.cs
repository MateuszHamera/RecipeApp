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
            AddProductViewModel = new AddProductViewModel();
            AddRecipeViewModel = new AddRecipeViewModel();
        }

        public AddProductViewModel AddProductViewModel { get; }
        public AddRecipeViewModel AddRecipeViewModel { get; }
        
    }
}
