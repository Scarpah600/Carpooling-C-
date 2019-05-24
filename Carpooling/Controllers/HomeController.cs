using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carpooling.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = " ";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tela Executiva para Ajuda";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Pagina Executiva para Contatos";

            return View();
        }
    }
}
