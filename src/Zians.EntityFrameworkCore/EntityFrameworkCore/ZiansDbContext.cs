using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Zians.EntityFrameworkCore
{
    public class ZiansDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public ZiansDbContext(DbContextOptions<ZiansDbContext> options) 
            : base(options)
        {

        }
    }
}
