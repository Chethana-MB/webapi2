using Microsoft.EntityFrameworkCore;
using webapi2;

namespace webapi2.data
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions<EmpContext> options) : base(options)

        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}




