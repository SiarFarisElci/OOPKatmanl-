using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.FluentValidation;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;
using System;

namespace Project.COREUI.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerManager _cMan;
        IJobManager _jMan;

        public CustomerController(ICustomerManager cMan, IJobManager jMan)
        {
            _cMan = cMan;
            _jMan = jMan;
        }

        public IActionResult Index()
        {
            CustomerVM cvm = new CustomerVM
            {
                Customers = _cMan.GetActives(),
                Jobs = _jMan.GetActives()
            };
            return View(cvm);
        }

        public IActionResult AddCustomer()
        {
            CustomerVM cvm = new()
            {
                Jobs = _jMan.GetActives()
            };
            
            return View(cvm);
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            CustomerValidator validationRules = new();
            ValidationResult result = validationRules.Validate(customer);
            if (result.IsValid)
            {
                _cMan.Add(customer);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }

        
            return View();
        }

        public IActionResult DeleteCustomer(int id)
        {
            _cMan.Delete(_cMan.Find(id));
            return RedirectToAction("Index");
        }

        public IActionResult UpdateCustomer(int id)
        {
            CustomerVM cvm = new CustomerVM
            {
                Customer = _cMan.Find(id),
                Jobs = _jMan.GetActives()
            };
            return View(cvm);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer customer)
        {
            _cMan.Update(customer);
            return RedirectToAction("Index");
        }
    }
}
