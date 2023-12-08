using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FinalProject.Model.Courts;

namespace FinalProject.Model
{
    public class BasketballCourts: AllCourts<BasketballCourt>//class aggreates all basketball courts in to a list
    {
        public BasketballCourts()
        {// constructor that creates a list of predefined basketball courts.
            CourtsList = new List<BasketballCourt>
            {
                new BasketballCourt(1, "BasketballCourt1"),
                new BasketballCourt(2, "BasketballCourt2"),
                new BasketballCourt(3, "BasketballCourt3"),
                new BasketballCourt(4, "BasketballCourt4")
            };
        }

    }
}
