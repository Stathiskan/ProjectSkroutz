﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Skroutz.Models
{
    public class AttributeValue
    {
        [Key]
        [Column(Order = 1)]
        [ForeignKey("Product")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("AttributeKey")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Attribute")]
        public int AttributeKeyId { get; set; }
        public virtual AttributeKey AttributeKey { get; set; }
        public string Value { get; set; }
    }
}
