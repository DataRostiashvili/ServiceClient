using ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity
{
    public class ServiceDescriptionEntity : IGenericEntity
    {
        #region interface implementation
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion
        public string? Description { get; set; }

        public ServicePacketEntity ServicePack { get; set; }
        public int ServicePackId { get;set; }

    }
}
