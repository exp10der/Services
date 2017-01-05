namespace Endpoint
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Http;
    using Data;
    using Microsoft.Owin.Hosting;

    public class EndpointController : ApiController, IEndpointService
    {
        private readonly string baseAddress = "http://localhost:9000/";
        private IDisposable _service;


        [HttpPost]
        [Route("api/endpoints")]
        public Task AddEndpointAsync(string serviceName)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/endpoints")]
        public Task<List<Service>> GetEndpointsAsync()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            _service = WebApp.Start<Startup>(baseAddress);
        }

        public void Stop()
        {
            _service.Dispose();
        }
    }
}