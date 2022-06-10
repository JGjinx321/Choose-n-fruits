using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_n__fruits.Models
{
    class Category
    {
        public Guid? CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription{ get; set; }

        static Category()
        {
            Category Tropical = new Category();

            Category Temperate = new Category();

            Category seedless = new Category();

            Category seeded = new Category();
        }
    }
}
