using System;

namespace Northwind.Domain.Common
{
    public abstract class AuditableEntity
    {
        public DateTime Created { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? LastModified { get; set; }

        public string LastModifiedBy { get; set; }
    }
}
