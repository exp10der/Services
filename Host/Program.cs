namespace Host
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
                    s.WhenStarted(es => es.Start());
                    s.WhenStopped(es => es.Stop());
                });
            });
        }
    }
}