using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controlleres
{
    public class ASXeberlerController : Controller
    {
        XəbərlərMenager xəbərlərMenager = new XəbərlərMenager(new EfXəbərlərDal());

        public IActionResult Index()
        {
            var values = xəbərlərMenager.TGetList();
            return View(values);
        }
    }
}
