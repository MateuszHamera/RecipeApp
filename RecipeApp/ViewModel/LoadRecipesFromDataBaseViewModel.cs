using RecipeApp.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RecipeApp.ViewModel
{
    class LoadRecipesFromDataBaseViewModel
    {
        public LoadRecipesFromDataBaseViewModel()
        {
            LoadRecipesFromDataBeseCommand = new DelegateCommand(LoadRecipesFromDataBese);
        }

        public ICommand LoadRecipesFromDataBeseCommand { get; set; }
        
        public void LoadRecipesFromDataBese()
        {

        }
    }
}
