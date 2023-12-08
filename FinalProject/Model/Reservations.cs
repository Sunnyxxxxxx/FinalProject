using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    // Declare the Reservations class
    public class Reservations
    {
        // A private field to store the list of court reservations.
        private List<Reservation> courtReservations;

        // Constructor for the Reservations class, initializing the courtReservations list.
        public Reservations()
        {
            courtReservations = new List<Reservation>();
        }
        // Method to add a court reservation with memberId, CourtID, reservationDate, and court.
        public bool AddCourtReservation(int memberId, int courtId, DateTime reservationDate, Court court)
        {
            // Create a new Reservation with memberId, courtId, and reservationDate.
            var reservation = new Reservation
            {
                MemberId = memberId,
                CourtId = courtId,
                ReservationDate = reservationDate
            };

            // Check if the reservation time is within the open time of the court.
            if (reservation.IsWithinCourtHours(court))
            {
                courtReservations.Add(reservation);
                Console.WriteLine("Reservation added successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Reservation time is outside court hours.");
                return false;
            }
        }

        // Method to retrieve a list of reservations for a specific member.
        public List<Reservation> GetReservationsByMemberId(int memberId)
        {
            return courtReservations.Where(r => r.MemberId == memberId).ToList();
        }



    }
}
