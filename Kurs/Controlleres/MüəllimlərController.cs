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
    public class MüəllimlərController : Controller
    {
        MüəllimlərManager müəllimlərMenager = new MüəllimlərManager(new EfMüəllimlərDal());
        public IActionResult Index()
        {
            var values = müəllimlərMenager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddMüəllimlər()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddMüəllimlər(Müəllimlər müəllimlər)
        {
            müəllimlərMenager.TAdd(müəllimlər);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateMüəllimlər(int id)
        {
            var values = müəllimlərMenager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateMüəllimlər(Müəllimlər müəllimlər)
        {
            müəllimlərMenager.TUpdate(müəllimlər);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMüəllimlər(int id)
        {
            var values = müəllimlərMenager.TGetByID(id);
            müəllimlərMenager.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
