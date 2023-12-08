using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Sessions
{
    public List<Session> sessions { get; set; }

    public Sessions()
    {
        sessions = new List<Session>();
    }

    public void AddSession(Session session)
    {
        sessions.Add(session);
    }

    public List<Session> GetSessionsByMemberId(int memberId)
    {
        return sessions.Where(s => s.MemberId == memberId).ToList();
    }
}
