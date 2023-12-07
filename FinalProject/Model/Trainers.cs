using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProject.Model.Trainers;

namespace FinalProject.Model;

public class Trainers
    {
        public List <Trainer> trainers { get; set; }

        public Trainers()
        {
            trainers = new List<Trainer>
            {
                new Trainer(1, "Trainer1", "Female", "Basketball"),
                new Trainer(2, "Trainer2", "Male", "Tennis"),
                new Trainer(3, "Trainer3", "Female", "Tennis"),
                new Trainer(4, "Trainer4", "Male", "Gym"),
                new Trainer(5, "Trainer5", "Female", "Gym"),
                new Trainer(6, "Trainer6", "Male", "Basketball")
            };
        }
    }
