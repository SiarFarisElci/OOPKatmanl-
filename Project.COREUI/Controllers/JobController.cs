using Microsoft.AspNetCore.Mvc;
using Project.BLL.FluentValidation;
using Project.BLL.ManagerServices.Abstracts;
using Project.COREUI.ViemClasses;
using Ptoject.ENTITIES.Entities;

namespace Project.COREUI.Controllers
{
    public class JobController : Controller
    {
        IJobManager _jMan;
        public JobController(IJobManager jMan)
        {
            _jMan = jMan;
        }
        public IActionResult Index()
        {
            JobVM jvm = new JobVM
            {
                Jobs = _jMan.GetActives()
            };
            return View(jvm);
        }

        public IActionResult AddJob()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddJob(Job job )
        {
            _jMan.Add(job);
                return RedirectToAction("Index");
          
        }

        public IActionResult DeleteJob(int id)
        {
            _jMan.Delete(_jMan.Find(id));
            return RedirectToAction("Index");
        }

        public IActionResult UpdateJob(int id)
        {
            JobVM jvm = new JobVM
            {
                Job = _jMan.Find(id)
            };
            return View(jvm);
        }
        [HttpPost]
        public IActionResult UpdateJob(Job job)
        {
            _jMan.Update(job);
            return RedirectToAction("Index");
        }
    }
}
