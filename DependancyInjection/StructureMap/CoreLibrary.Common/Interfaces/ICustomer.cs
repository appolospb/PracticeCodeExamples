using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Common.Interfaces
{
    public interface ICustomer
    {
        string Forename { get; set; }
        string Surname { get; set; }
        DateTime DOB { get; set; }
    }
}
