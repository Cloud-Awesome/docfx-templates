using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

namespace SampleFunctionsApp.HttpTriggers
{
    /// <summary>
    /// **Get the version of the current Functions App**
    ///
    /// This is some more information...
    /// </summary>
    public static class Version
    {
        /// <summary>
        /// GET the version of the current Functions App
        /// </summary>
        /// <param name="req">HttpRequest, nothing is currently processed from it</param>
        /// <param name="log">ILogger</param>
        /// <returns></returns>
        [FunctionName("Version")]
        public static Task<IActionResult> RunAsync(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request");
            return Task.FromResult<IActionResult>((ActionResult)new OkObjectResult("1.0.0"));
        }
    }
}