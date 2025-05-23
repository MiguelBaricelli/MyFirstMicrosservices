﻿using GeekShooping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace GeekShooping.ProductAPI.Model
{
    [Table("Product")]
    public class Product : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("price")]
        [Required]
        [Range(1, 10000)]
        [Precision(18,2)]
        
        public decimal Price { get; set; }

        [Column("description")]
        [StringLength(300)]
        public string Description { get; set; }

        [Column("category_name")]
        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        [Column("image_url")]
        [Required]
        [StringLength(300)]
        public string ImageUrl { get; set; }
    }
}
