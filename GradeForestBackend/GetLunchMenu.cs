using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.Storage.Table;
using GradeForestBackend.Helpers;

namespace GradeForestBackend
{
    public static class GetLunchMenu
    {
        [FunctionName("GetLunchMenu")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Table("LunchMenu")] CloudTable cloudTable,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string day = req.Query["day"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            day = day ?? data?.day;

            return day != null
                ? (ActionResult)new OkObjectResult(await AzureStorageHelper.GetLunchMenuAsync(cloudTable, day))
                : new BadRequestObjectResult("Please pass a name on the query string or in the request body");
        }
    }
}
