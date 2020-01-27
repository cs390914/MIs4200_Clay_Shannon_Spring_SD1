using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int CurrentWeight { get; set; }
        public int GoalWeight { get; set; }
        public DateTime ClientSince { get; set; }
        public ICollection<TrainingSessions> Trainingsessions { get; set; }

    }
}