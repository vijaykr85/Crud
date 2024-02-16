using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Crud.Models
{
    public class CrudDbContext : DbContext
    {
        public CrudDbContext (DbContextOptions<CrudDbContext> options) : base(options) 
        {
           
        }

        public DbSet<Crud> Students { get; set; }

        public DbSet<Student> StudentDetails { get; set; }
    }
}
