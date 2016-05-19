using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLibrary.Common.Interfaces;

namespace CoreLibrary.Common.Models
{
    public class Customer : ICustomer
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DOB { get; set; }
    }
}
