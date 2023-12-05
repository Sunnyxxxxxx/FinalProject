using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProject.Model.Trainers;

namespace FinalProject.Model;

public class Trainers
    {
        public List<Trainer> trainers { get; set; }

        public Trainers()
        {
            trainers = new List<Trainer>();
        }
    }
