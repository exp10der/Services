﻿namespace Host
{
    using Endpoint;
    using Topshelf;

    internal class Program
    {
        private static void Main()
        {
            HostFactory.Run(cfg =>
            {
                cfg.Service<EndpointService>(s =>
                {
                    s.ConstructUsing(() => new EndpointService());
                    s.WhenStarted(es => es.Start());
                    s.WhenStopped(es => es.Stop());
                });

                cfg.RunAsLocalSystem();

                cfg.SetDescription("Endpoint service");      
                cfg.SetDisplayName("Endpoint");                  
                cfg.SetServiceName("Endpoint");                  
            });
        }
    }
}