using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using StandardLibrary;
using System.Collections.Generic;

namespace AzFun
{
    public static class DemoHttpFun
    {
        [FunctionName("demohttpfun")]
        public static async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequest req, ILogger log)
        {
            IMathOperationService mathService = new MathOperationService(20, 5);
            Dictionary<string, int> obj = new Dictionary<string, int>();
            log.LogInformation($"Add - {mathService.Add()}");
            obj.Add("Add", mathService.Add());

            log.LogInformation($"Sub - {mathService.Sub()}");
            obj.Add("Sub", mathService.Sub());

            log.LogInformation($"Mul - {mathService.Mul()}");
            obj.Add("Mul", mathService.Mul());

            log.LogInformation($"Div - {mathService.Div()}");
            obj.Add("Div", mathService.Div());
         
            return (ActionResult)new OkObjectResult(obj);
        }
    }
}
