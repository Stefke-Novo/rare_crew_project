using Microsoft.EntityFrameworkCore;
using ServerApp.Models;

namespace ServerApp
{
    public class DBContext :DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options){}
        public DbSet<Employee> Employees { get; set; }
    }
}
