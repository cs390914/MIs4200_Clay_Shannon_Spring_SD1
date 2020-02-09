using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class RaceOrg
    {
        public int RaceOrgID { get; set; }
        public string Description { get; set; }
        public decimal RaceFee { get; set; }
        public ICollection<CarDetail> OrderDetail { get; set; }

    }
}