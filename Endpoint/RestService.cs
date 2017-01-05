namespace Endpoint
{
    using System;
    using Microsoft.Owin.Hosting;

    public class RestService
    {
        private readonly string baseAddress = "http://localhost:9000/";
        private IDisposable _service;

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