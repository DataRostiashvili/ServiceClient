using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Services.Interfaces
{
    public interface IPasswordHashService
    {
        string Hash(string password);
        bool Verify(string hashedPassword, string password);
    }
}
