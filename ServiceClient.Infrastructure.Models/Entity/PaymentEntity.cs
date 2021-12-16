using ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity
{
    public class PaymentEntity : IGenericEntity
    {

        #region interface implementation
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public PaymentType PaymentType { get; set; }
        public Currency Currency { get; set; }

        [Range(0, (double)decimal.MaxValue)]
        public decimal Amount { get; set; }



        public ServicePacketEntity ServicePack { get; set; }
        public int ServicePackId { get; set; }


    }

    public enum PaymentType
    {
        Hourly,
        Fixed,

    }

    public enum Currency
    {

        GEL,
        USD,
        RUB
    }
}
