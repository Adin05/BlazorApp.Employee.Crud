using BlazorApp.Employee.Crud.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Employee.Crud.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opt):base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-2I02PR4E;Database=MyEmployeeDb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<Tb_Employee> Employees { get; set; }
    }
}
