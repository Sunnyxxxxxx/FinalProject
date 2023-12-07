using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Sessions
{
    public List <Session> sessions { get; set; }
    public Sessions()
    {
        sessions = new List<Session>
            {
                new Session(1, "Session1"),
                new Session(2, "Session2"),
                new Session(3, "Session3"),
                new Session(4, "Session4"),
                new Session(5, "Session5"),
                new Session(6, "Session6")
            };
    }
}
