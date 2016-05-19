using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLibrary.Common.Interfaces;

namespace CoreLibrary.Interfaces
{
    public interface ICoreLibrary
    {
        void AddCustomer(ICustomer customer);
        void GetCustomers();
    }
}
