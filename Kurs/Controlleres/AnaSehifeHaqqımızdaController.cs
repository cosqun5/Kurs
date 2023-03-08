using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controlleres
{
    public class AnaSehifeHaqqımızdaController : Controller
    {
        HaqqımızdaMenager haqqımızdaManager = new HaqqımızdaMenager(new EfHaqqımızdaDal());
        public IActionResult Index()
        {
            var values = haqqımızdaManager.TGetList();
            return View(values);
        }
    }
}
