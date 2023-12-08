using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;
// Declare a trainer class
public class Trainer
{
    // Declare public properties to store Trainer Id, Trainer Name, Age, Gender, Type, WorkStartTime, and WorkEndTime.
    public int TrainerId { get; set; }
    public string TrainerName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public string Type { get; set; }
    public TimeSpan WorkStartTime { get; set; }
    public TimeSpan WorkingEndTime { get; set; }

    // Constructor for the Trainer class with trainerID, trainerName, Gender and type.
    public Trainer(int trainerId, string trainerName, string gender, string type)
    {
        TrainerId = trainerId;
        TrainerName = trainerName;
        Gender = gender;
        Type = type;
        WorkStartTime = new TimeSpan(6, 0, 0); // 6 AM
        WorkingEndTime = new TimeSpan(22, 0, 0); // 10 PM
    }

    // Method to show if the reservation is during the operating hours of the given trainer available time.
    public bool IsAvailableAt(DateTime sessionDate)
    {
        TimeSpan sessionTime = sessionDate.TimeOfDay;
        return sessionTime >= WorkStartTime && sessionTime <= WorkingEndTime;
    }
}
