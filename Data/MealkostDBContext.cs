
using WebApp_MealKostV2.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp_MealKostV2.Data
{

    public class MealkostDBContext : DbContext
    {
        public MealkostDBContext(DbContextOptions<MealkostDBContext> options) : base(options)
        {
        }

        public DbSet<tbl_menu> tbl_menu { get; set; }
        public DbSet<tbl_paket_menu> vw_paket_menu { get; set; }
        //public DbSet<Enrollment> Enrollments { get; set; }
        //public DbSet<Student> Students { get; set; }

    }


}
