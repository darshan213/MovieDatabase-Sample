using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieDatabase.Controllers
{
    public class TankitaController : Controller
    {
        // GET: Tankita
        public ActionResult Years()
        {
            return View();
        }
    }
}