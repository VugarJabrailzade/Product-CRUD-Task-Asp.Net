﻿using Task1_asp.Net.Database.Models;

namespace Task1_asp.Net.Database
{
    public class DbContext
    {
        public static int _productId;
        public static int _sliderproductId;


        public static List<Product> _product = new List<Product>()
        {
            
            new Product("Lavender Marigold","100% Organic, Fresh","pink","small",550),
            new Product("Orchid Heart","100% Organic, Fresh","purple","medium",250),
        };

        public static List<sliderProduct> _sliderProduct = new List<sliderProduct>()
        {
            new sliderProduct("Jasmine","100% Natural, Organic",1,25),
            new sliderProduct("Orchid","100% Natural, Organic",2,45)

        };
    }
}