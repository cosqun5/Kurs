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
    public class ASƏlaqəController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Mesaj p)
        {
            MesajMenager mesajMenager = new MesajMenager(new EfMesajDal());
            p.Tarix = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Status = true;
            mesajMenager.TAdd(p);
            return View();
        }
    }
}
