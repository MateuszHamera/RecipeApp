using RecipeApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Servives
{
    class ConnectWithProductsDataBase
    {

        public string Name { get; set; }
        public double Weight { get; set; }

        public void AddProductToDataBase()
        {
            Product product = new Product()
            {
                Name = Name,
                Weight = Weight
            };
            
            using(SQLiteConnection connection = new SQLiteConnection(App.productsDatabasePath))
            {
                connection.CreateTable<Product>();
                connection.Insert(product);
            }
        }

        public void RemoveProductWithDataBase()
        {

        }
        
        public void UpdateProductInDataBase()
        {

        }
    }
}
