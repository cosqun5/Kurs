using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controlleres
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult SolMenyu()
        {
            return PartialView();
        }
    }
}
