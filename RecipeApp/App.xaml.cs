using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace RecipeApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string folderdatabase = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        static string recipesNameDataBase = "Recipes.db";
        public static string recipesDatabasePath = System.IO.Path.Combine(folderdatabase, recipesNameDataBase);

        static string productsNameDataBase = "Products.db";
        public static string productsDatabasePath = System.IO.Path.Combine(folderdatabase, productsNameDataBase);
    }
}
