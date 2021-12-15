using System;

namespace ServiceClient.Infrastructure.Models.Interfaces.Audit
{
    public interface IEntityDeleteAudit
    {
        DateTime? DeletedAt { get; set; }
    }
}
