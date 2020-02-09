using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MIs4200_Clay_Shannon_Spring_SD1.Models;

namespace MIs4200_Clay_Shannon_Spring_SD1.DAL
{
    public class MIS4200Context : DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
    }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<RaceOrg> RaceOrgs { get; set; }
    public DbSet<CarDetail  > CarDetails { get; set; }
}