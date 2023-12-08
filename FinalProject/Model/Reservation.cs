using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Reservation
{
    public DateTime ReservationDate { get; set; }
    public int MemberId { get; set; }
    public int CourtId { get; set; }

    public bool IsWithinCourtHours(Court court)
    {
        return ReservationDate.TimeOfDay >= court.OpeningTime && ReservationDate.TimeOfDay <= court.ClosingTime;
    }

}

