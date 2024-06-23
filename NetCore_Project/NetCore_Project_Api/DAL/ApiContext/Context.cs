using Microsoft.EntityFrameworkCore;
using NetCore_Project_Api.DAL.Entity;

namespace NetCore_Project_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=CAGLA\\SQLEXPRESS;database=CoreProjeDB2;integrated security=true;trustServerCertificate=true");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
