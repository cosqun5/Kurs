﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Xəbərlər
    {
        [Key]
        public int XəbərlərID { get; set; }
        public string Başlıq { get; set; }
        public string Məlumat { get; set; }
        public string Şəkil { get; set; }
    }
}
