using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.Controlleres
{
    public class ASMuellimController : Controller
    {
        MüəllimlərManager müəllimlərMenager = new MüəllimlərManager(new EfMüəllimlərDal());
        public IActionResult Index()
        {
            var values = müəllimlərMenager.TGetList();
            return View(values);
        }
    }
}
