using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.FluentValidation;
using Project.BLL.ManagerServices.Abstracts;
using Project.BLL.ManagerServices.Concrates;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;

namespace Project.COREUI.Controllers
{
    public class ProductController : Controller
    {
       private  IProductManager _pMan;
       private  ICategoryManager _cMan;

        public ProductController(IProductManager pMan , ICategoryManager cMan )
        {
            _cMan = cMan;
            _pMan = pMan;
        }
        public IActionResult Index()
        {
            ProductVM pvm = new ProductVM
            {
                Products = _pMan.GetActives(),
                Categories = _cMan.GetActives()
            };

            return View(pvm);
        }

        public IActionResult AddProduct()
        {
           
            ProductVM pvm = new ProductVM
            {
                Categories = _cMan.GetActives()
            };
            return View(pvm);
        }
        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            ProductValidation validationRules = new ProductValidation();
            ValidationResult result = validationRules.Validate(product);
            if (result.IsValid)
            {
                _pMan.Add(product);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName , item.ErrorMessage);
                }
            }

            return View();
            
        }

        public IActionResult DeleteProduct(int id)
        {
            _pMan.Delete(_pMan.Find(id));

            return RedirectToAction("Index");
        }


        public IActionResult UpdateProduct(int id)
        {
            ProductVM pvm = new ProductVM
            {
                Product = _pMan.Find(id),
                Categories = _cMan.GetActives()
            };

            return View(pvm);
        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            _pMan.Update(product);

            return RedirectToAction("Index");
        }

    }
}
