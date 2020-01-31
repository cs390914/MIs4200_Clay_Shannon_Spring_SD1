using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class TrainingSessions
    {
        
        [Key]
        public int TrainingSessionID { get; set; }
        public string Description { get; set; }
        public DateTime TrainingSessionDate { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; } 
    }
}