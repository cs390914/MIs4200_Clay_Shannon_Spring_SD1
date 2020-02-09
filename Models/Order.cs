using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public string Description { get; set; }
        public int ShippingFee { get; set; }

        public DateTime OrderDate { get; set; }

        public ICollection<CarDetail> CarDetail { get; set; }

        public int CarID { get; set; }
        public virtual Car Car { get; set; }
    }
}