using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottsService.Models
{
    public class GetMoneyRequest
    {
        public int AnnualSalary { get; set; }
        public decimal WeeklyHoursWorked { get; set; }
    }
}
