using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLibrary.Common.Interfaces;
using CoreLibrary.Interfaces;
using CoreLibrary.DAL.Interfaces;
using StructureMap;

namespace CoreLibrary
{
    public class CoreLibrary : ICoreLibrary
    {
        #region Fields

        private Container _container;
        private ICoreLibraryDAL _coreLibDAL;

        #endregion

        public CoreLibrary()
        {
            InitIOC iniIOC = new InitIOC();
            _container = iniIOC.Resolver(_container);

            _coreLibDAL = _container.GetInstance<ICoreLibraryDAL>();
        }

        public void AddCustomer(ICustomer customer)
        {
            _coreLibDAL.AddCustomer(customer);
        }

        public void GetCustomers()
        {
            _coreLibDAL.GetCustomers();
        }
    }
}
