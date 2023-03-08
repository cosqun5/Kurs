using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Tələbələr
    {
        [Key]
        public int TələbələrID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Şəkil { get; set; }
        public string Nəticəsi { get; set; }
        public string Məlumat { get; set; }

    }
}
