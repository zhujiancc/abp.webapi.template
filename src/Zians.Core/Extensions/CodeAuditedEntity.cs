using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zians.Extensions
{
    public class CodeAuditedEntity : AuditedEntity
    {
        public string Code { get; set; } = Guid.NewGuid().ToString("N");
    }
}
