using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication1.Models
{
    public partial class TestDbContext : DbContext
    {

        public TestDbContext(DbContextOptions<TestDbContext> options)
            : base(options)
        {
        }

       // public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<TblProcess> TBL_PROCESS { get; set; }
        public virtual DbSet<TblQueue> TBL_QUEUE { get; set; }
        public virtual DbSet<TblCatchword> TBL_CATCHWORD { get; set; }
        public virtual DbSet<TblCategory> TBL_CATEGORY { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\ProjectsV13;Database=TestDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
