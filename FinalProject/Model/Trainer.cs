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
    public TimeSpan WorkStartTime { get; set; }
    public TimeSpan WorkingEndTime { get; set; }

    public Trainer(int trainerId, string trainerName, string gender, string type)
    {
        TrainerId = trainerId;
        TrainerName = trainerName;
        Gender = gender;
        Type = type;
        WorkStartTime = new TimeSpan(6, 0, 0); // 6 AM
        WorkingEndTime = new TimeSpan(22, 0, 0); // 10 PM
    }

    public bool IsAvailableAt(DateTime sessionDate)
    {
        TimeSpan sessionTime = sessionDate.TimeOfDay;
        return sessionTime >= WorkStartTime && sessionTime <= WorkingEndTime;
    }
}
