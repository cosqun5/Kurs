using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class TələbələrManager : ITələbələrService
    {
        ITələbələrDal _tələbələrDal;

        public TələbələrManager(ITələbələrDal tələbələrDal)
        {
            _tələbələrDal = tələbələrDal;
        }

        public void TAdd(Tələbələr t)
        {
            _tələbələrDal.insert(t);
        }

        public void TDelete(Tələbələr t)
        {
            _tələbələrDal.Delete(t);
        }

        public Tələbələr TGetByID(int id)
        {
            return _tələbələrDal.GetByID(id);
        }

        public List<Tələbələr> TGetList()
        {
            return _tələbələrDal.GetList();
        }

        public void TUpdate(Tələbələr t)
        {
            _tələbələrDal.Update(t);
        }
    }
}
