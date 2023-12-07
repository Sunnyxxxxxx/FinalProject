using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Reservations
    {
        private List<Reservation> courtReservations;

        public Reservations()
        {
            courtReservations = new List<Reservation>();
        }

        public void AddCourtReservation(int memberId, int courtId, DateTime reservationDate, Court court)
        {
            // 创建新的预约实例
            var reservation = new Reservation
            {
                MemberId = memberId,
                CourtId = courtId,
                ReservationDate = reservationDate
            };

            // 检查预约时间是否在球场开放时间内
            if (reservation.IsWithinCourtHours(court))
            {
                courtReservations.Add(reservation);
                Console.WriteLine("Reservation added successfully.");
            }
            else
            {
                Console.WriteLine("Reservation time is outside court hours.");
            }
        }

        public List<Reservation> GetReservationsByMemberId(int memberId)
        {
            return courtReservations.Where(r => r.MemberId == memberId).ToList();
        }

    }
}
