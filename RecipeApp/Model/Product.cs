using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Model
{
    public class Product
    {
        public Product()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string Name { get; set; }
    }
}
