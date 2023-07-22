using Microsoft.EntityFrameworkCore;

namespace Casgem_ChainOfResponsibility.Dal
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-AKOHCIC;initial catalog=Casgem_ChainOfResponsibility;integrated security=true");
        }
        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
