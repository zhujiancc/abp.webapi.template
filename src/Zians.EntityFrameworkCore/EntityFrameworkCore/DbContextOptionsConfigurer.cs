using Microsoft.EntityFrameworkCore;

namespace Zians.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<ZiansDbContext> dbContextOptions,
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for ZiansDbContext */
            dbContextOptions.UseNpgsql(connectionString);
        }
    }
}
