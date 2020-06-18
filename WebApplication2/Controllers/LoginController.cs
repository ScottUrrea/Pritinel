using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult InicioSesion()
        {
            return View();
        }

        public ActionResult Registrar()
        {
            return View();
        }

    }
}
