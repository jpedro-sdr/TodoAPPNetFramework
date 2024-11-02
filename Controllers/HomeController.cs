using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApplicationNetFramework.DbContext.Repositories;
using TodoApplicationNetFramework.Models.Entidades;

namespace TodoApplicationNetFramework.Controllers
{
    public class HomeController : Controller
    {
        private readonly TimeRepository _repository = new TimeRepository();

        public ActionResult Index()
        {
            ViewBag.ViewModel = _repository.GetAll();
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
        
        [HttpPost]
        public ActionResult Create(Time time)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(time);
                return RedirectToAction("Index");
            }
            return View(time);
        }
        
    }
}