using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary.Common.Interfaces
{
    public interface IError
    {
        Exception Ex { get; set; }
        bool Pass { get; set; }
        string Msg { get; set; }
    }
}
