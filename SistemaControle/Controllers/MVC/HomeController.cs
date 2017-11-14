using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaControle.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sistema Alunos Beta";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Entre em contato";

            return View();
        }
    }
}