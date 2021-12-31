using ServiceClient.Infrastructure.Services;
using System;
using Xunit;

namespace ServiceClient.Test.Infrastructure.Service
{
    public class PasswordHashServiceTest
    {

        [Fact]
        public void same_input_should_provide_same_output()
        {
            var service = new PasswordHashService();

            var guid = Guid.NewGuid().ToString();
            var hashed = service.Hash(guid);

            Assert.True(service.Verify(hashed, guid));
        }

        [Fact]
        public void different_input_should_provide_different_output()
        {
            var service = new PasswordHashService();

            var guid = Guid.NewGuid().ToString();
            var hashed = service.Hash(guid);


            Assert.False(service.Verify(hashed, guid.Substring(0, guid.Length - 2)));
        }
    }
}