using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class TennisCourts
    {
        public List<TennisCourt> tenniscourts { get; set; }

        public TennisCourts()
        {
            tenniscourts = new List<TennisCourt>
            {
                new TennisCourt(1, "TennisCourt1"),
                new TennisCourt(2, "TennislCourt2"),
                new TennisCourt(3, "TennisCourt3"),
                new TennisCourt(4, "TennisCourt4"),
                new TennisCourt(5, "TennisCourt5"),
                new TennisCourt(6, "TennisCourt6")
            };
        }
    }
}
