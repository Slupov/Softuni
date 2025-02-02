﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ProductShop.Models
{
    public class Product
    {
        public Product()
        {
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }

        [Required,MinLength(3)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int SellerId { get; set; }

        public virtual User Seller { get; set; }

        public int? BuyerId { get; set; }

        public virtual User Buyer { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}