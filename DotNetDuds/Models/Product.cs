using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetDuds.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString ="{0:c}")]
        [Range(0.01,9999999)]
        public double Price { get; set; }

        public string Description { get; set; }

        public string image { get; set; }

        [Display(Name ="Category")]
        public int CategoryId { get; set; }

        // product is the child of category
        public Category Category { get; set; }
    }
}
