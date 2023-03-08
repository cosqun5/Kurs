﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IÜmumiDal<T> where T : class
    {
        void insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T>GetList();
        T GetByID(int id);

    }
}
