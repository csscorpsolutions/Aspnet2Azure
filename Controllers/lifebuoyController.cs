using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aspnet2Azure.Controllers
{
    public class lifebuoyController : Controller
    {
        // GET: lifebuoy
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HandSanitizer()
        {
            return View();
        }
    }
}