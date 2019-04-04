using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Zians.EntityFrameworkCore
{
    [DependsOn(
        typeof(ZiansCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class ZiansEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZiansEntityFrameworkCoreModule).GetAssembly());
        }
    }
}