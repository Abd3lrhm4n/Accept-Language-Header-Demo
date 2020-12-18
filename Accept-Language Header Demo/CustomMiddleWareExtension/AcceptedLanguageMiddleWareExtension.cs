using Accept_Language_Header_Demo.CustomMiddleWares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Accept_Language_Header_Demo.CustomMiddleWareExtension
{
    public static class AcceptedLanguageMiddleWareExtension
    {
        public static IApplicationBuilder UseAcceptedLanguage(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<AcceptedLanguageMiddleWare>();
        }
    }
}
