﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DomainLayer.ProductModel
{
    [Table("Images")]
    public class Images
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string imagePath { get; set; }

    }
}
