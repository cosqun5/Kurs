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
    public class TələbələrController : Controller
    {
        TələbələrManager tələbələrManager = new TələbələrManager(new EfTələbələrDal());
        public IActionResult Index()
        {
            var values = tələbələrManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddTələbələr()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTələbələr(Tələbələr tələbələr)
        {
            tələbələrManager.TAdd(tələbələr);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateTələbələr(int id)
        {
            var values = tələbələrManager.TGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTələbələr(Tələbələr tələbələr)
        {
            tələbələrManager.TUpdate(tələbələr);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTələbələr(int id)
        {
            var values = tələbələrManager.TGetByID(id);
            tələbələrManager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
