using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Trainer
{
    public int TrainerId { get; set; }
    public string TrainerName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Type { get; set; }

    public Trainer(int trainerId, string trainerName, string gender, string type)
    {
        TrainerId = trainerId;
        TrainerName = trainerName;
        Gender = gender;
        Type = type;
    }
}
