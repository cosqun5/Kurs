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
    public class ƏlaqəMenager : IƏlaqəService
    {
        IƏlaqəDal _əlaqəDal;
        public ƏlaqəMenager(IƏlaqəDal əlaqəDal)
        {
            _əlaqəDal = əlaqəDal;
        }

        public void TAdd(Əlaqə t)
        {
            _əlaqəDal.insert(t);
        }

        public void TDelete(Əlaqə t)
        {
            _əlaqəDal.Delete(t);
        }

        public Əlaqə TGetByID(int id)
        {
            return _əlaqəDal.GetByID(id);
        }

        public List<Əlaqə> TGetList()
        {
           return _əlaqəDal.GetList();
        }

        public void TUpdate(Əlaqə t)
        {
             _əlaqəDal.Update(t);
        }
    }
}
