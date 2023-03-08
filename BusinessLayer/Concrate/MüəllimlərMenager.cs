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
    public class MüəllimlərManager : IMüəllimlərService
    {
        IMüəllimlərDal _müəllimlərDal;

        public MüəllimlərManager(IMüəllimlərDal müəllimlərDal)
        {
            _müəllimlərDal = müəllimlərDal;
        }

        public void TAdd(Müəllimlər t)
        {
            _müəllimlərDal.insert(t);
        }

        public void TDelete(Müəllimlər t)
        {
            _müəllimlərDal.Delete(t);
        }

        public Müəllimlər TGetByID(int id)
        {
            return _müəllimlərDal.GetByID(id);
        }

        public List<Müəllimlər> TGetList()
        {
            return _müəllimlərDal.GetList();
        }

        public void TUpdate(Müəllimlər t)
        {
           _müəllimlərDal.Update(t);
        }
    }
}
