using HelthPassport.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace HelthPassport.Services.EF
{
    public class AppDbContext : DbContext
    {
        public DbSet<Change> Changes { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Division> Divisions { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Graft> Grafts { get; set; }
        public DbSet<Femily> Femilies { get; set; }
        public DbSet<EmployeePositionCatregory> PositionCatregories { get; set; }
        public DbSet<EmployeePosition> Positions { get; set; }
        public DbSet<EmployeeMoving> Movings { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public AppDbContext()
            : base()
        {
        }

        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     optionsBuilder.UseSqlite(Directory.GetCurrentDirectory() + @"\DataBase.db");
        // }
    }
}