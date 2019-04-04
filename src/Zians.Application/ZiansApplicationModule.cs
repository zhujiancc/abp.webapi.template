using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Zians
{
    [DependsOn(
        typeof(ZiansCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ZiansApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZiansApplicationModule).GetAssembly());
        }
    }
}