using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class TrainingDetail
    {
        [Key]
        public int TrainingDetailID { get; set; }
        public string Equipment { get; set; }
        public int TrainingDuration { get; set; }
        public string WorkoutType { get; set; }

        public int TrainingsessionID { get; set; }
        public virtual TrainingSessions TrainingSessions { get; set; }

        public int TrainerID { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}