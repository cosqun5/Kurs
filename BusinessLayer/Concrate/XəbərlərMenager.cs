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
    public class XəbərlərMenager : IXəbərlərService
    {
        IXəbərlərDal _xəbərlərDal;

        public XəbərlərMenager(IXəbərlərDal xəbərlərDal)
        {
            _xəbərlərDal = xəbərlərDal;
        }

        public void TAdd(Xəbərlər t)
        {
            _xəbərlərDal.insert(t);
        }

        public void TDelete(Xəbərlər t)
        {
            _xəbərlərDal.Delete(t);
        }

        public Xəbərlər TGetByID(int id)
        {
            return _xəbərlərDal.GetByID(id);
        }

        public List<Xəbərlər> TGetList()
        {
            return _xəbərlərDal.GetList();
        }

        public void TUpdate(Xəbərlər t)
        {
            _xəbərlərDal.Update(t);
        }
    }
}
