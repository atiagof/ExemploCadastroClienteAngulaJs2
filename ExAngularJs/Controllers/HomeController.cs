using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExAngularJs.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CadastroUsuario()
        {
            return View();
        }

        public ActionResult ConsultaUsuario()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }
    }
}
