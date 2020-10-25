using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
// model name are singular
namespace DotNetDuds.Models
{
    public class Category
    {
        // prop
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        // add refrence to the child object

        public List<Product> Products { get; set; }
    }
}
