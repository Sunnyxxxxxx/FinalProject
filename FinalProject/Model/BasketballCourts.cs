using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class BasketballCourts
    {
        public List<BasketballCourt> basketballcourts { get; set; }

        public BasketballCourts()
        {
            basketballcourts = new List<BasketballCourt>
            {
                new BasketballCourt(1, "BasketballCourt1"),
                new BasketballCourt(2, "BasketballCourt2"),
                new BasketballCourt(3, "BasketballCourt3"),
                new BasketballCourt(4, "BasketballCourt4")
            };
        }


    }
}
