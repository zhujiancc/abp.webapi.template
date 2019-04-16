using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zians.Books
{
    public class Book : FullAuditedEntity
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public DateTime  PublishTime { get; set; }
    }
}
