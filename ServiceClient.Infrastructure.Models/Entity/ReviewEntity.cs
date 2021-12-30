using ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit;
using ServiceClient.Infrastructure.Models.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ServiceClient.Infrastructure.Models.Entity
{
    public class ReviewEntity : IGenericEntity
    {
        #region interface implementation
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        [Range(1, 5)]
        public uint? Ranking { get; set; }
        public string Review { get; set; }

    }
}
