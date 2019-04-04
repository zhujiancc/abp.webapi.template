using System;
using System.Threading.Tasks;
using Abp.TestBase;
using Zians.EntityFrameworkCore;
using Zians.Tests.TestDatas;

namespace Zians.Tests
{
    public class ZiansTestBase : AbpIntegratedTestBase<ZiansTestModule>
    {
        public ZiansTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<ZiansDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<ZiansDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<ZiansDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ZiansDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<ZiansDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<ZiansDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<ZiansDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<ZiansDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
