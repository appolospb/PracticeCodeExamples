using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScottsService.Models;
using ScottsService.Implementation;

namespace ScottsService
{
    public class ScottsService : IScottsService
    {
        private Money _money;

        public ScottsService()
        {
            _money = new Money();
        }

        public string GetMessage(string name)
        {
            return string.Format("Hello {0}", name);
        }

        public GetMoneyResponse GetMoney(GetMoneyRequest request)
        {
            GetMoneyResponse response = new GetMoneyResponse();

            response = _money.CalculateMoney(request);

            return response;
        }
    }
}
