using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Reservation
{
    public int ReservationId { get; set; }
    public DateTime ReservationDate { get; set; }
    public int MemberId { get; set; }
    public int courtId { get; set; }
    private static int Reservationcount;
    public Reservation()
    {
        Reservationcount++;
        ReservationId = Reservationcount;
    }

    public bool IsWithinCourtHours(Court court)
    {
        return ReservationDate.TimeOfDay >= court.OpeningTime && ReservationDate.TimeOfDay <= court.ClosingTime;
    }

}

