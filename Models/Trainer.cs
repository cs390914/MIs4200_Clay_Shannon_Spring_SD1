using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIs4200_Clay_Shannon_Spring_SD1.Models
{
    public class Trainer
    {
        public int TrainerID { get; set; }
       
        public string Description { get; set; }
        public DateTime TrainerSince { get; set; }

        public ICollection<TrainingDetail> TrainingDetails { get; set; }
    }
}