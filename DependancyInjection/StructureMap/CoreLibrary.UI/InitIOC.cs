using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;
using StructureMap.Graph;
using CoreLibrary.Common.Interfaces;
using CoreLibrary.Common.Models;

using CoreLibrary.Interfaces;

namespace CoreLibrary.UI
{
    public class InitIOC
    {
        public Container Resolver(Container container)
        {
            container = new Container();

            container.Configure(resolver => {

                resolver.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });

                resolver.For<ICustomer>().Use<Customer>();
                resolver.For<ICustomers>().Use<Customers>();
                resolver.For<IError>().Use<Error>();

                resolver.For<ICoreLibrary>().Use<CoreLibrary>();

            });

            return container;
        }
    }
}
