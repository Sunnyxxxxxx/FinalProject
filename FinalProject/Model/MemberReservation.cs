using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class MemberReservation
{
        public Member member { get; set; }
        public Reservation reservation { get; set; }

        public MemberReservation (Member m, Reservation r)
        {
            member = m;
            reservation = r;
        }
}
