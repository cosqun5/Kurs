using DataAccessLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.ViewComponents.Dashboard
{
    public class BildirimStatistic : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Tələbələrs.Count();
            ViewBag.v2 = c.Müəllimlərs.Count();
            ViewBag.v3 = c.Mesajs.Where(x => x.Status == false).Count();
            return View();
        }
    }
}
