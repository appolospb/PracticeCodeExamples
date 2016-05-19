using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLibrary.Common.Interfaces;

namespace CoreLibrary.Common.Models
{
    public class Customers : ICustomers
    {
        public List<ICustomer> CustomerList { get; set; }

        public Customers()
        {
            CustomerList = new List<ICustomer>();
        }
    }
}
