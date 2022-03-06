﻿using Entities.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Products
{
    public class Whiskey : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string PhotoUrl { get; set; }


        public WhiskeyCategory Category { get; set; }
    }
}
