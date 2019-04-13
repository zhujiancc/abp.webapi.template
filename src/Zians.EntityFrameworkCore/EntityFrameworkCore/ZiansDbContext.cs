using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Zians.Books;

namespace Zians.EntityFrameworkCore
{
    public class ZiansDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public DbSet<Book> Books { get; set; }

        //Add DbSet properties for your entities...
        public ZiansDbContext(DbContextOptions<ZiansDbContext> options)
            : base(options)
        {

        }
    }
}
