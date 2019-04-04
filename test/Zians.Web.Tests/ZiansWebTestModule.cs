using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Zians.WebApi;

namespace Zians.Web.Tests
{
    [DependsOn(
        typeof(ZiansWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class ZiansWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZiansWebTestModule).GetAssembly());
        }
    }
}