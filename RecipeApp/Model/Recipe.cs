using SQLite;
using System.Collections.Generic;

namespace RecipeApp.Model
{
    public class Recipe
    {
        public Recipe(List<Product> products)
        {
            Products = products;
        }

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Product> Products { get; set; }
    }
}
