using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.ViewComponents.Telebeler
{
    public class TelebelerList:ViewComponent
    {
        TələbələrManager tələbələrManager = new TələbələrManager(new EfTələbələrDal());
        public IViewComponentResult Invoke()
        {
            var values = tələbələrManager.TGetList();
            return View(values);
        }
    }
}
