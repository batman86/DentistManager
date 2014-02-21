using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DentistManager.Domain.DAL.Abstract;

namespace DentistManager.DentistUI.Controllers
{
    public class HomeController : Controller
    {
        ItestRepository testRepository;
        public HomeController(ItestRepository _testRepository)
        {
            testRepository = _testRepository;
        }
        public ActionResult Index()
        {
            ViewBag.text1 = testRepository.GetTesting();
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
    }
}