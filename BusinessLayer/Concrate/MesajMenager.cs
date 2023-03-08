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
    public class MesajMenager : IMesajService
    {
        IMesajDal _mesajDal;

        public MesajMenager(IMesajDal mesajDal)
        {
            _mesajDal = mesajDal;
        }

        public void TAdd(Mesaj t)
        {
            _mesajDal.insert(t);
        }

        public void TDelete(Mesaj t)
        {
            _mesajDal.Delete(t);
        }

        public Mesaj TGetByID(int id)
        {
            return _mesajDal.GetByID(id);
        }

        public List<Mesaj> TGetList()
        {
            return _mesajDal.GetList();
        }

        public void TUpdate(Mesaj t)
        {
            _mesajDal.Update(t);
        }
    }
}
