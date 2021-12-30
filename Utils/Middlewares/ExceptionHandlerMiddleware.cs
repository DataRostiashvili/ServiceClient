using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Middlewares
{
    public class ExceptionHandlerMiddleware
    {

        private readonly RequestDelegate _request;
        public ExceptionHandlerMiddleware(RequestDelegate request)
        {
            _request = request;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _request(context);
            }
            catch (Exception exception)
            {
                var response = context.Response;
                response.ContentType = "text/json";

                if (exception is BaseCustomException)
                    response.StatusCode = (int)HttpStatusCode.BadRequest;
                else
                    response.StatusCode = (int)HttpStatusCode.NotFound;

                var result = JsonSerializer.Serialize(exception.Message);
                await response.WriteAsync(exception.ToString());
            }
        }
    }
}
