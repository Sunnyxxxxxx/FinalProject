using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProject.Model.Courts;

namespace FinalProject.Model
{
    public class TennisCourts : AllCourts<TennisCourt>
    {//class aggreates all basketball courts in to a list
        public TennisCourts()
        {// constructor that creates a list of predefined tennis courts.
            CourtsList = new List<TennisCourt>
            {
                new TennisCourt(5, "TennisCourt1"),
                new TennisCourt(6, "TennisCourt2"),
                new TennisCourt(7, "TennisCourt3"),
                new TennisCourt(8, "TennisCourt4"),
                new TennisCourt(9, "TennisCourt5"),
                new TennisCourt(10, "TennisCourt6")
            };

        }
    }
}
