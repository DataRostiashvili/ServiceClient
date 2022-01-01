using AutoMapper;
using ServiceClient.Infrastructure.Models.Api.Identity;
using ServiceClient.Infrastructure.Models.DTO;
using ServiceClient.Infrastructure.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Mappings
{
    public class UserMappings : Profile
    {
        public UserMappings()
        {
            CreateMap<UserEntity, UserDTO>()
                .ForMember(dto => dto.UserId, conf => conf.MapFrom(ent => ent.Id));

            CreateMap<RegistrationRequest, UserEntity>();
            CreateMap<UserUpdateRequest, UserEntity>();

        }
    }
}
