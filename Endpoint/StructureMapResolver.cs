namespace Endpoint
{
    using System.Web.Http.Dependencies;
    using StructureMap;

    public class StructureMapResolver : StructureMapDependencyScope, IDependencyResolver
    {
        private readonly IContainer _container;

        public StructureMapResolver(IContainer container)
            : base(container)
        {
            _container = container;
        }

        public IDependencyScope BeginScope() =>
            new StructureMapDependencyScope(_container.GetNestedContainer());
    }
}