using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using StructureMap;
using StructureMap.Graph;
using CoreLibrary.DAL.Interfaces;
using CoreLibrary.DAL;
using CoreLibrary.Common.Interfaces;
using CoreLibrary.Common.Models;

namespace CoreLibrary
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

                resolver.For<ICoreLibraryDAL>().Use<CoreLibraryDAL>();
                resolver.For<ICustomers>().Use<Customers>();

            });

            return container;
        }
    }
}
