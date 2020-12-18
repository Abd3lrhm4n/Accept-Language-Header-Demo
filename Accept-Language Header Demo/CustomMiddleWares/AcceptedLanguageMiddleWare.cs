using Accept_Language_Header_Demo.Utilities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accept_Language_Header_Demo.CustomMiddleWares
{
    public class AcceptedLanguageMiddleWare
    {
        private readonly RequestDelegate _next;
        private readonly Language _language;

        public AcceptedLanguageMiddleWare(RequestDelegate next, Language language)
        {
            _next = next;
            _language = language;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            //Read body from the request and log it
            var Accept_Language = httpContext.Request.Headers["Accept-Language"];

            _language.Value = Accept_Language.ToString();

            //Move to next delegate/middleware in the pipleline
            await _next.Invoke(httpContext);
        }
    }
}
