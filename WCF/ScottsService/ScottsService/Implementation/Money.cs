using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScottsService.Models;

namespace ScottsService.Implementation
{
    public class Money
    {
        public GetMoneyResponse CalculateMoney(GetMoneyRequest request)
        {
            GetMoneyResponse response = new GetMoneyResponse();

            response.Monthly = request.AnnualSalary / 12;
            response.Weekly = request.AnnualSalary / 52;
            response.Daily = response.Weekly / 5;
            response.Hourly = Math.Round(response.Weekly / request.WeeklyHoursWorked, 2);

            return response;
        }
    }
}
