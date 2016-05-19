using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLibrary.DAL.Interfaces;
using CoreLibrary.Common.Interfaces;

namespace CoreLibrary.DAL
{
    public class CoreLibraryDAL : ICoreLibraryDAL
    {
        private ICustomers _customerList;

        public CoreLibraryDAL(ICustomers customerList)
        {
            _customerList = customerList;
        }

        public void AddCustomer(ICustomer customer)
        {
            // TODO - Replace 'void' with 'IAddCustomerResponse'
            // TODO - Get SQLExpress installed and hookup EF
        }

        public ICustomers GetCustomers()
        {
            // TODO - Replace 'ICustomers' with 'IGetCustomersResponse'
            // TODO - Get SQLExpress installed and hookup EF
            return _customerList;
        }
    }
}
