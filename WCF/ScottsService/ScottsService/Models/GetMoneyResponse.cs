using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottsService.Models
{
    public class GetMoneyResponse
    {
        public int Monthly { get; set; }
        public int Weekly { get; set; }
        public int Daily { get; set; }
        public decimal Hourly { get; set; }
    }
}
