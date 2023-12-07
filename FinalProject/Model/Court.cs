using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public abstract class Court
    {

        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public int CourtID { get; set; }
        public string CourtName { get; set; }
        protected Court(int courtId, String courtName)
        {
            OpeningTime = new TimeSpan(6, 0, 0);//6a.m.
            ClosingTime = new TimeSpan(22, 0, 0);//10p.m.
            CourtID = courtId;
            CourtName = courtName;
        }

    }
}
