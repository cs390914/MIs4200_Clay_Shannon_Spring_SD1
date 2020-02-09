using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string LicensePlate { get; set; }
        public string NickName { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}