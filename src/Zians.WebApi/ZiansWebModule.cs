using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Zians.Configuration;
using Zians.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Zians.WebApi
{
    [DependsOn(
        typeof(ZiansApplicationModule), 
        typeof(ZiansEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class ZiansWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ZiansWebModule(IHostingEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(ZiansConsts.ConnectionStringName);

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(ZiansApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ZiansWebModule).GetAssembly());
        }
    }
}