using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProject.Model.Courts;

namespace FinalProject.Model
{
    public class TennisCourts : Courts<TennisCourt>
    {
        public TennisCourts()
        {
            CourtsList = new List<TennisCourt>
            {
                new TennisCourt(1, "TennisCourt1"),
                new TennisCourt(2, "TennisCourt2"),
                new TennisCourt(3, "TennisCourt3"),
                new TennisCourt(4, "TennisCourt4"),
                new TennisCourt(5, "TennisCourt5"),
                new TennisCourt(6, "TennisCourt6")
            };

        }
    }
}
