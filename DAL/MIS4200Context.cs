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
        public MIS4200Context() : base("name=cs390914-SDConnection")
        {


            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,
            Migrations.MISContext.Configuration>("cs390914-SDConnection"));
        }
        public DbSet<Client> Clients { get; set; }
        public DbSet<TrainingSessions> TrainingSessions { get; set; }
        public DbSet<TrainingDetail> TrainingDetails { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}