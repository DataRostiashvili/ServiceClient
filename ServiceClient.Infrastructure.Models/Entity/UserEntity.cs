
using Microsoft.AspNetCore.Identity;
using ServiceClient.Infrastructure.Models.Entity.Interfaces.Audit;
using ServiceClient.Infrastructure.Models.Interfaces;
using ServiceClient.Infrastructure.Models.Interfaces.Audit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity
{
    public abstract class UserEntity :  IGenericEntity
    {
        #region interface implementation
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        #endregion

        public string UserName { get; set; }
        public string PasswordHash { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string? IdNumber { get; set; }
        public string? Address { get; set; }
        

    }

   

   



}
