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
    public class HaqqımızdaMenager : IHaqqımızdaService
    {
        IHaqqımızdaDal _haqqımızdaDal;

        public HaqqımızdaMenager(IHaqqımızdaDal haqqımızdaDal)
        {
            _haqqımızdaDal = haqqımızdaDal;
        }

        public void TAdd(Haqqımızda t)
        {
            _haqqımızdaDal.insert(t);
        }

        public void TDelete(Haqqımızda t)
        {
            _haqqımızdaDal.Delete(t);
        }

        public Haqqımızda TGetByID(int id)
        {
            return _haqqımızdaDal.GetByID(id);
        }

        public List<Haqqımızda> TGetList()
        {
            return _haqqımızdaDal.GetList();
        }

        public void TUpdate(Haqqımızda t)
        {
            _haqqımızdaDal.Update(t);
        }
    }
}
