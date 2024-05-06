using Core_Proje_Api.DAL.Entity;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Core_Proje_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = OMERFARUKPALA; database = CoreCvProjectApi; integrated security = true;");
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
