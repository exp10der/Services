namespace Endpoint
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Data;

    public interface IEndpointService
    {
        Task AddEndpointAsync(string serviceName);
        Task<List<Service>> GetEndpointsAsync();
    }
}