using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

//Declare a session class
public class Session
{
    // Declare public properties to store SessionDate, MemeberId, and TrainerId.
    public DateTime SessionDate { get; set; }
    public int MemberId { get; set; }
    public int TrainerId { get; set; }
    // Constructor for the Sessions class with SessionDate, MemeberId, and TrainerId.
    public Session(DateTime sessionDate, int memberId, int trainerId)
    {
        SessionDate = sessionDate;
        MemberId = memberId;
        TrainerId = trainerId;
    }

}