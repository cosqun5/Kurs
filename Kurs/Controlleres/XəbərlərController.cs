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
    public class XəbərlərController : Controller
    {
        XəbərlərMenager xəbərlərMenager = new XəbərlərMenager(new EfXəbərlərDal());
        public IActionResult Index()
        {
            var values = xəbərlərMenager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddXəbərlər()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddXəbərlər(Xəbərlər xəbərlər)
        {
            xəbərlərMenager.TAdd(xəbərlər);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateXəbərlər(int id)
        {
            var values = xəbərlərMenager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateXəbərlər(Xəbərlər xəbərlər)
        {
            xəbərlərMenager.TUpdate(xəbərlər);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteXəbərlər(int id)
        {
            var values = xəbərlərMenager.TGetByID(id);
            xəbərlərMenager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
