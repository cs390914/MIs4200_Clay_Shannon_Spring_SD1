using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string NickName { get; set; }
        public string Type { get; set; }
        public string Style { get; set; }
        public string Price { get; set; }
        public DateTime ProSince { get; set; }
        public ICollection<Order> Order { get; set; }

    }
}