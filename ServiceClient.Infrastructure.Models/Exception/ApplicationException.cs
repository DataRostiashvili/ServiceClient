using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceClient.Infrastructure.Models.Exception
{
    public class ApplicationException : System.Exception
    {
        public ApplicationException(string Message, System.Exception innerException)
             : base(Message, innerException)
        {

        }
    }
}
