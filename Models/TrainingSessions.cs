using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class TrainingSessions
    {
        public int TrainingSessionID { get; set; }
        public string Description { get; set; }
        public int TrainingTime { get; set; }
        public string Equipment { get; set; }
        public string TrainingGoal { get; set; }
        public DateTime TrainingSessionDate { get; set; }
    }
}