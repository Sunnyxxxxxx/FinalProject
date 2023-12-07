using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Trainer
{
    private static int autoIncreament;
    public int TrainerId { get; set; }
    public string TrainerName { get; set; }
    public int Age { get; set; }
    public char Gender { get; set; }
    public string Type { get; set; }

    public Trainer(int TrainerId, string trainerName)
    {
        autoIncreament++;
        TrainerId = autoIncreament;
    }
}
