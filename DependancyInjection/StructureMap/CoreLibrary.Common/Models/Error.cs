using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CoreLibrary.Common.Interfaces;

namespace CoreLibrary.Common.Models
{
    public class Error : IError
    {
        public Exception Ex { get; set; }
        public bool Pass { get; set; }
        public string Msg { get; set; }
    }
}
