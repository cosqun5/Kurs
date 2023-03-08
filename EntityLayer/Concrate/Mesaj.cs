using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Mesaj
    {
        [Key]

        public int MesajID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Məlumat { get; set; }
        public DateTime Tarix { get; set; }
        public bool Status { get; set; }
    }
}
