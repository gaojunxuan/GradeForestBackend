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
    public static class GetAnnouncement
    {
        [FunctionName("GetAnnouncement")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            [Table("Announcement")] CloudTable cloudTable,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");


            return (ActionResult)new OkObjectResult(await AzureStorageHelper.GetAnnouncementListAsync(cloudTable));
        }
    }
}
