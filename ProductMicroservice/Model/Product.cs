﻿using Microsoft.EntityFrameworkCore;

namespace ProductMicroservice.Model
{
    [Keyless]
    public class Product
    {
        
        int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}
