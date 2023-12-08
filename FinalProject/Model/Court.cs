using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public abstract class Court
    {//properties representing the opening and closing time for a court and unique identifierannd name for a court.

        public TimeSpan OpeningTime { get; set; }
        public TimeSpan ClosingTime { get; set; }
        public int CourtID { get; set; }
        public string CourtName { get; set; }
        protected Court(int courtId, String courtName)
        {//protected constructor for the court class that initializes the court with ann ID name and default openinng and closing time
            OpeningTime = new TimeSpan(6, 0, 0);//6a.m.
            ClosingTime = new TimeSpan(22, 0, 0);//10p.m.
            CourtID = courtId;
            CourtName = courtName;
        }

    }
}
