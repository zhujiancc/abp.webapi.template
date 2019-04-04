using Abp.Application.Services;

namespace Zians
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ZiansAppServiceBase : ApplicationService
    {
        protected ZiansAppServiceBase()
        {
            LocalizationSourceName = ZiansConsts.LocalizationSourceName;
        }
    }
}