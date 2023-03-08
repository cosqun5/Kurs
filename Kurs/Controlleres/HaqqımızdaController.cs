using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controlleres
{
    public class HaqqımızdaController : Controller
    {
        HaqqımızdaMenager haqqımızdaMenager = new HaqqımızdaMenager(new EfHaqqımızdaDal());
        public IActionResult Index()
        {
            var values = haqqımızdaMenager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddHaqqımızda()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddHaqqımızda(Haqqımızda haqqımızda)
        {
            haqqımızdaMenager.TAdd(haqqımızda);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateHaqqımızda(int id)
        {
            var values = haqqımızdaMenager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateHaqqımızda(Haqqımızda haqqımızda)
        {
            haqqımızdaMenager.TUpdate(haqqımızda);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteHaqqımızda(int id)
        {
            var values = haqqımızdaMenager.TGetByID(id);
            haqqımızdaMenager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
