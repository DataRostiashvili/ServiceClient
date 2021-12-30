using ServiceClient.Infrastructure.Models.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit
{
    public  interface IGenericEntity
        : IEntity<Guid>, IEntityAudit, IEntityDeleteAudit, IEntityState
    {
    }
}
