using Core_App_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_App_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DD\\SQLEXPRESS01;database=CoreAppApiDb;integrated security=true;TrustServerCertificate=True;");
        }
        public DbSet<Category> Categories { get; set; }
    }
}
