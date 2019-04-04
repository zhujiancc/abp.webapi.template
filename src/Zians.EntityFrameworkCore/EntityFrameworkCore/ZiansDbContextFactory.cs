using Zians.Configuration;
using Zians.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Zians.EntityFrameworkCore   
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class ZiansDbContextFactory : IDesignTimeDbContextFactory<ZiansDbContext>
    {
        public ZiansDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ZiansDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(ZiansConsts.ConnectionStringName)
            );

            return new ZiansDbContext(builder.Options);
        }
    }
}