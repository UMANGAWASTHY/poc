using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using StandardLibrary;
using System.Collections.Generic;

namespace AzFun
{
    public static class DemoHttpFun
    {
        [FunctionName("demohttpfun")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get")]HttpRequestMessage req, TraceWriter log)
        {
            IMathOperationService mathService = new MathOperationService(20, 5);
            Dictionary<string, int> obj = new Dictionary<string, int>();
            log.Info($"Add - {mathService.Add()}");
            obj.Add("Add", mathService.Add());

            log.Info($"Sub - {mathService.Sub()}");
            obj.Add("Sub", mathService.Sub());

            log.Info($"Mul - {mathService.Mul()}");
            obj.Add("Mul", mathService.Mul());

            log.Info($"Div - {mathService.Div()}");
            obj.Add("Div", mathService.Div());

            return req.CreateResponse(HttpStatusCode.OK, obj);
        }
    }
}
