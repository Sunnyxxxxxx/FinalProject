using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class MemberReservation
{// links a member with a reservation, representing a booking bby a member
        public Member member { get; set; }
        public Reservation reservation { get; set; }

        public MemberReservation (Member m, Reservation r)
        {//constructor that takes a member object and the reservation object to create an association betwween them
            member = m;
            reservation = r;
        }
}
