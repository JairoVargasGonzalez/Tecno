using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectoAplicacionesII.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Vision()
        {
            return View();
        }

        public ActionResult Productos()
        {
            return View();
        }

        public ActionResult Impresoras()
        {
            return View();
        }
    }

}