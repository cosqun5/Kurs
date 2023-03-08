﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Müəllimlər
    {
        [Key]
        public int MüəllimlərID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string İxtisas { get; set; }
        public string Məlumat { get; set; }
        public string Şəkil { get; set; }

    }
}
