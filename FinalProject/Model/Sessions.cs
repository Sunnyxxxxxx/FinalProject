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

    public bool AddSessionReservation(int memberId, int trainerId, DateTime sessionDate)
    {
        // 检查是否存在时间冲突
        bool hasConflict = sessions.Any(s => s.TrainerId == trainerId && s.SessionDate == sessionDate);
        if (hasConflict)
        {
            return false; // 如果有冲突，则返回 false
        }

        var newSession = new Session (sessionDate,memberId, trainerId)
        {
            MemberId = memberId,
            TrainerId = trainerId,
            SessionDate = sessionDate
        };

        sessions.Add(newSession);
        return true; // 如果没有冲突，则添加会话并返回 true
    }
}
