namespace Endpoint
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http.Dependencies;
    using StructureMap;

    public class StructureMapDependencyScope : IDependencyScope
    {
        private IContainer _container;

        public StructureMapDependencyScope(IContainer container)
        {
            _container = container;
        }

        public void Dispose()
        {
            _container?.Dispose();

            _container = null;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == null)
                return null;

            return serviceType.IsAbstract || serviceType.IsInterface
                ? _container.TryGetInstance(serviceType)
                : _container.GetInstance(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
            => _container.GetAllInstances(serviceType)
                .Cast<object>();
    }
}