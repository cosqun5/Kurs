using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kurs.ViewComponents.Dashboard
{
    public class MüəllimStatistic : ViewComponent
    {
        MüəllimlərManager müəllimlərMenager = new MüəllimlərManager(new EfMüəllimlərDal());
        public IViewComponentResult Invoke()
        {

            var values = müəllimlərMenager.TGetList();
            return View(values);
        }

    }
}
