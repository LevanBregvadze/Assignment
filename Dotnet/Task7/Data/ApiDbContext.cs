using Microsoft.EntityFrameworkCore;
using Task7.Models;

namespace Task7.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) :
            base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Teacher_Pupil>()
                .HasOne(t => t.Teacher)
                .WithMany(tp => tp.Teacher_Pupils)
                .HasForeignKey(ti => ti.TeacherId);


            modelBuilder.Entity<Teacher_Pupil>()
               .HasOne(p => p.Pupil)
               .WithMany(tp => tp.Teacher_Pupils)
               .HasForeignKey(pi => pi.PupilId);
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Pupil> Pupils { get; set; }

        public DbSet<Teacher_Pupil> Teacher_Pupils { get; set; }


    }
}
