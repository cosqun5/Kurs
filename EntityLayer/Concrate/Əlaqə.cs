using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
   public class Əlaqə
    {
        [Key]
        public int ƏlaqəID { get; set; }
        public string Fecabook { get; set; }
        public string Instagram { get; set; }
        public int Telefon { get; set; }
    }
}
