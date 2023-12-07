using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public abstract class Court // Common properties and methods for all courts

    public TimeSpan OpeningTime { get; set; }
    public TimeSpan ClosingTime { get; set; }

    protected Court()
    {
        OpeningTime = new TimeSpan(6, 0, 0);//6a.m.
        ClosingTime = new TimeSpan(22, 0, 0);//10p.m.
        NumberOfCourts = numberOfCourts;
    }

    
}
