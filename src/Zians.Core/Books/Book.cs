using System;
using Zians.Extensions;

namespace Zians.Books
{
    public class Book : CodeAuditedEntity
    {
        public string Name { get; set; }

        public DateTime Publish { get; set; }
    }
}
