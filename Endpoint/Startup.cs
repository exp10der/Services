namespace Endpoint
{
    using System.Web.Http;
    using Owin;

    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.DependencyResolver = new StructureMapResolver(IoC.Container);

            appBuilder.UseWebApi(config);
        }
    }
}