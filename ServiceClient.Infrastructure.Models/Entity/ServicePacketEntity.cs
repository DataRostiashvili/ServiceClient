using ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity
{
    public class ServicePacketEntity  : IGenericEntity
    {
        #region interface implementation
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion


        public PaymentEntity Payment { get; set; }
        public int paymentId { get; set; }


        public ServiceDescriptionEntity ServiceDescription { get; set; }
        public int ServiceDescriptionId { get; set; }



    }
}
