﻿using System.ComponentModel.DataAnnotations;

namespace BloggingPlatform.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
    }
}
