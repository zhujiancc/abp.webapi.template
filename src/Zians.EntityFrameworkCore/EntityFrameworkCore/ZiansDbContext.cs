using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zians.Books;

namespace Zians.EntityFrameworkCore
{
    public class ZiansDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...
        public DbSet<Book> Books { get; set; }

        public ZiansDbContext(DbContextOptions<ZiansDbContext> options) 
            : base(options)
        {

        }
    }
}
