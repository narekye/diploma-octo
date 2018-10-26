using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using OCTO.Admin.Models;
using System;
using System.Net;
using System.Threading.Tasks;

namespace OCTO.Admin.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next) { _next = next; }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next?.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        static Task HandleException(HttpContext context, Exception ex)
        {
            var model = new ResponseWrapper<object>
            {
                Data = null,
                State = "Danger",
                HasError = true,
                Message = ex.Message
            };

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var result = JsonConvert.SerializeObject(model);
            return context.Response.WriteAsync(result);
        }
    }
}
