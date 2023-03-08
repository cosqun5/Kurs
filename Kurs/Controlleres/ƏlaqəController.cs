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
    public class ƏlaqəController : Controller
    {
        ƏlaqəMenager əlaqəMenager = new ƏlaqəMenager(new EfƏlaqəDal());
        public IActionResult Index()
        {
            var values = əlaqəMenager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddƏlaqə()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddƏlaqə(Əlaqə əlaqə)
        {
            əlaqəMenager.TAdd(əlaqə);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateƏlaqə(int id)
        {
            var values = əlaqəMenager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateƏlaqə(Əlaqə əlaqə)
        {
            əlaqəMenager.TUpdate(əlaqə);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteƏlaqə(int id)
        {
            var values = əlaqəMenager.TGetByID(id);
            əlaqəMenager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}

