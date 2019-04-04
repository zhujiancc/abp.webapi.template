using Zians.EntityFrameworkCore;

namespace Zians.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly ZiansDbContext _context;

        public TestDataBuilder(ZiansDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}