using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Choose_n__fruits.Models
{
    class Product
    {
        public Guid? ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductColor { get; set; }

        public string ProductSC { get; set; }

        public string ProductDescription{ get; set; }

        public string ProductSkinType { get; set; }

        public double ProductPrice { get; set; }

        public int CategoryId { get; set; }

        public int QuantityInStock { get; set; }

        public Product(Product product)
        {
            product.ProductName = ProductName;

            product.ProductColor = ProductColor;

            product.ProductSC = ProductSC;

            product.ProductDescription = ProductDescription;

            product.ProductSkinType = ProductSkinType;

            product.ProductPrice = ProductPrice;

            product.CategoryId = CategoryId;

            product.QuantityInStock = QuantityInStock;
        }
    }
}
