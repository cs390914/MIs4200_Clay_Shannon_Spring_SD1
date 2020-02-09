namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class CarDetail
    {
        public int CarDetailID { get; set; }
        public int RaceNumber { get; set; }
        public decimal Price { get; set; }
        public string RaceTeam { get; set; }

        public int OrderID { get; set; }
        public virtual Order Order { get; set;


        public int RaceOrgID { get; set; }
        public virtual RaceOrg RaceOrg { get; set; }
    }
}