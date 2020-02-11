using RecipeApp.Model;
using RecipeApp.ViewModel.Command;
using SQLite;
using System.Collections.Generic;
using System.Windows.Input;

namespace RecipeApp.ViewModel
{
    class LoadRecipesFromDataBaseViewModel
    {
        private List<Recipe> _recipes;
        public LoadRecipesFromDataBaseViewModel()
        {
            LoadRecipesFromDataBeseCommand = new DelegateCommand(LoadRecipesFromDataBese);
        }

        public ICommand LoadRecipesFromDataBeseCommand { get; set; }
        
        public void LoadRecipesFromDataBese()
        {
            using (SQLiteConnection connection = new SQLiteConnection(App.DatabasePath))
            {
                connection.CreateTable<Recipe>();
                //_recipes = (connection.Table<Recipe>())
                //    .OrderBy(r => r.Name)
                //    .ToList();
            }
        }
    }
}
