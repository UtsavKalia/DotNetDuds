using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DotNetDuds.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetDuds.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            // use the category model to create & populate a list of 10 categories
            var categories = new List<Category>();
            // use a loop to create 10 fake objects
            for(var i = 1; i <= 10; i++)
            {
                categories.Add(new Category() { Id = 1, Name = "Category " + i.ToString() });
            }

            return View(categories);
        }
        public IActionResult Browse(string category)
        {
            // pass the incoming category back to the browse view
            // using the viewbag container object
            ViewBag.category = category;
            return View();
        }
    }
}
