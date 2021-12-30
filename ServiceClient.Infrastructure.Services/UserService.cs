using AutoMapper;
using ServiceClient.Infrastructure.Data.Repositories;
using ServiceClient.Infrastructure.Models.Api.Identity;
using ServiceClient.Infrastructure.Models.DTO;
using ServiceClient.Infrastructure.Models.Entity;
using ServiceClient.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly UserRepository _repository;
        private readonly IMapper _mapper;


        public UserService(
            UserRepository repository,
            IMapper mapper
            )
        {
            _mapper = mapper;
            _repository = repository;
        }
        public Task<UserDTO?> Authenticate(AuthenticateRequest request)
        {
            UserDTO? res = null;

            var userEntity = _repository
                .GetByPredicate(user => user.UserName == request.UserName)
                .Where(u => u.PasswordHash == request.PasswordHash)
                .SingleOrDefault();

            if (userEntity != null)
               res = _mapper.Map<UserDTO>(userEntity);

            return Task.FromResult(res);
        }

        public Task<UserDTO?> GetUer(Guid userId)
        {
            UserDTO? res = null;

            var userEntity = _repository
                .GetByPredicate(user => user.Id == userId)
                .SingleOrDefault();

            if (userEntity != null)
                res = _mapper.Map<UserDTO>(userEntity);

            return Task.FromResult(res);
        }

        public Task<UserDTO?> GetUer(string userName)
        {
            UserDTO? res = null;

            var userEntity = _repository
                .GetByPredicate(user => user.UserName == userName)
                .SingleOrDefault();

            if (userEntity != null)
                res = _mapper.Map<UserDTO>(userEntity);

            return Task.FromResult(res);
        }

        public async Task Register(RegistrationRequest request)
        {
            var entity = _mapper.Map<UserEntity>(request);

            await _repository.InsertAsync(entity);

        }
    }
}
