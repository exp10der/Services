namespace Endpoint
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data;

    public class StubEndpointService : IEndpointService
    {
        public Task AddEndpointAsync(string serviceName) => Task.FromResult(0);

        public Task<List<Service>> GetEndpointsAsync()
            => Task.FromResult(new List<Service>
            {
                new Service {Id = 1, Name = "Stub Service"}
            });
    }
}