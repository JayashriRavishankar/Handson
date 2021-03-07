using ASPCoreLog4Net.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreLog4Net
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        private readonly ILoggerManager logger;
        public HandleExceptionAttribute()
        {
            this.logger = new LoggerManager();
        }
        public override void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustomError" };
            var modelMetadata = new EmptyModelMetadataProvider();
            result.ViewData = new ViewDataDictionary(
                    modelMetadata, context.ModelState);
            result.ViewData.Add("HandleException",
                    context.Exception);
            context.Result = result;
            logger.LogInformation(context.Exception.ToString());
            context.ExceptionHandled = true;
        }
    }
}
