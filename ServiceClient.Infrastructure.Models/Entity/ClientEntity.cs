﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Entity
{
    public class ClientEntity : UserEntity
    {
        public ICollection<ClientGroupEntity> ClientGroups { get; set; }

    }
}
