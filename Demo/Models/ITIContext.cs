using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    public class ITIContext :DbContext
    {
        public ITIContext(DbContextOptions<ITIContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> departments { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=RasElbarR1;Integrated Security=True;Trust Server Certificate=True");
        //}
    }
}
