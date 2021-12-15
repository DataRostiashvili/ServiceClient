using System;

namespace ServiceClient.Infrastructure.Models.Interfaces.Audit
{
    public interface IEntityAudit
    {
        DateTime CreatedAt { get; set; }

        DateTime? ModifiedAt { get; set; }
    }
}
