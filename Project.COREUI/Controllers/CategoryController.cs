using Microsoft.AspNetCore.Mvc;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;

namespace Project.COREUI.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryManager _cMan;
        public CategoryController(ICategoryManager cMan)
        {
            _cMan = cMan;
        }

        public IActionResult Index()
        {
            CategoryVM jvm = new()
            {
                Categories = _cMan.GetActives()
            };
            return View(jvm);
        }

        public IActionResult AddCategory()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCategory(Category  category )
        {
            _cMan.Add(category);
            return RedirectToAction("Index");

        }

        public IActionResult DeleteCategory(int id)
        {
            _cMan.Delete(_cMan.Find(id));
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCategory(int id)
        {
            CategoryVM cvm = new()
            {
                Category = _cMan.Find(id)
            };
            return View(cvm);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category )
        {
            _cMan.Update(category);
            return RedirectToAction("Index");
        }
    }
}
