using System.Collections.Generic;
using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;

namespace WorldToolsApi
{
    public class World
    {
        private readonly ILogger _logger;

        public World(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<World>();
        }

        [Function("World")]
        public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = "world/{slug: string}")] HttpRequestData req,
         string slug)
        {
            _logger.LogInformation($"Get World by Slug: {slug}");

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString($"World {slug}");

            return response;
        }
    }
}
