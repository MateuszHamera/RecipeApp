using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Model
{
    class Ingredient
    {
        public Ingredient()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
    }
}
