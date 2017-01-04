namespace Endpoint
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data;

    public class EndpointService : IEndpointService
    {
        public Task AddEndpointAsync(string serviceName)
        {
            throw new NotImplementedException();
        }

        public Task<List<Service>> GetEndpointsAsync()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
        }

        public void Stop()
        {
        }
    }
}