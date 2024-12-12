using CRUDAppp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUDAppp.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = CategoriesRepository.GetCategories();
            return View(categories);
        }

        /*[formroute] specifie la source
         * [httpGet] par defaut, pas besoin de spécifier
         */
        public IActionResult Edit([FromRoute] int? id)
        {
            var categoryId = CategoriesRepository.GetCategoryById(id.HasValue ? id.Value : 0);
            return View(categoryId);
        }

        [HttpPost]
        public IActionResult Edit(Category category) 
        {
            CategoriesRepository.UpdateCategory(category.CategoryId, category);
            return RedirectToAction(nameof(Index));
        }
    }
}
