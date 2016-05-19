using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Common.Interfaces
{
    public interface ICustomers
    {
        List<ICustomer> CustomerList { get; set; }
    }
}
