using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

// Declare the Reservation class
public class Reservation
{
    // Declare public properties to store reservation date, member Id, court Id.
    public DateTime ReservationDate { get; set; }
    public int MemberId { get; set; }
    public int CourtId { get; set; }

    // Method to show if the reservation is during the operating hours of the given court.
    public bool IsWithinCourtHours(Court court)
    {
        return ReservationDate.TimeOfDay >= court.OpeningTime && ReservationDate.TimeOfDay <= court.ClosingTime;
    }

}

