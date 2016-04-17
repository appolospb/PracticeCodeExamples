using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel; // Req for WCF service
using ScottsService.Models;

namespace ScottsService
{
    [ServiceContract]
    public interface IScottsService
    {
        [OperationContract]
        string GetMessage(string name);

        [OperationContract]
        GetMoneyResponse GetMoney(GetMoneyRequest request);
    }
}
