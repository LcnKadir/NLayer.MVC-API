﻿namespace NLayer.Core.Model
{
    public class Product : BaseEntitiy
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public ProductFeature ProductFeature { get; set; }
    }

}