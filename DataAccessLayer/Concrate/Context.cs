using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate
{
   public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-37EF8O4\\SQLEXPRESS;database=ZəkalarKursu; integrated security=true");
        }
        public DbSet<Əlaqə> Əlaqəs { get; set; }
        public DbSet<Haqqımızda> Haqqımızdas { get; set; }
        public DbSet<Xəbərlər> Xəbərlərs { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }
        public DbSet<Müəllimlər> Müəllimlərs { get; set; }
        public DbSet<Tələbələr> Tələbələrs { get; set; }
    }
}
