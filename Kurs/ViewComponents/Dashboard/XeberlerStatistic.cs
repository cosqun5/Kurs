using BusinessLayer.Concrate;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.ViewComponents.Dashboard
{
    public class XeberlerStatistic : ViewComponent
    {
        XəbərlərMenager xəbərlərMenager = new XəbərlərMenager(new EfXəbərlərDal());
        public IViewComponentResult Invoke()
        {

            var values = xəbərlərMenager.TGetList();
            return View(values);
        }
    }
}
