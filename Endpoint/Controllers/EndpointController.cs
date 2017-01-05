namespace Endpoint.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Data;

    public class EndpointController : ApiController
    {
        private readonly IEndpointService _endpointService;

        public EndpointController(IEndpointService endpointService)
        {
            _endpointService = endpointService;
        }

        [HttpPost]
        [Route("api/endpoints")]
        public Task AddEndpointAsync(string serviceName) => _endpointService.AddEndpointAsync(serviceName);

        [HttpGet]
        [Route("api/endpoints")]
        public Task<List<Service>> GetEndpointsAsync() => _endpointService.GetEndpointsAsync();
    }
}