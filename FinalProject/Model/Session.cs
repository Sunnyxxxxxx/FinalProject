using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Session
{
    public DateTime SessionDate { get; set; }
    public int MemberId { get; set; }
    public int TrainerId { get; set; }

    public Session(DateTime sessionDate, int memberId, int trainerId)
    {
        SessionDate = sessionDate;
        MemberId = memberId;
        TrainerId = trainerId;
    }

}