using Abp.Modules;
using Abp.Reflection.Extensions;
using Zians.Localization;

namespace Zians
{
    public class ZiansCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            ZiansLocalizationConfigurer.Configure(Configuration.Localization);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZiansCoreModule).GetAssembly());
        }
    }
}