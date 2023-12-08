using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

// Declare a Sessions class
public class Sessions
{
    // A property to store a list of sessions.
    public List<Session> sessions { get; set; }

    // A constructor for the Sessions class and set the session list.
    public Sessions()
    {
        sessions = new List<Session>();
    }
    //Add new session to session list.
    public void AddSession(Session session)
    {
        sessions.Add(session);
    }
    //Get a list of sessions by memberId.
    public List<Session> GetSessionsByMemberId(int memberId)
    {
        return sessions.Where(s => s.MemberId == memberId).ToList();
    }

    //Add a new sessionn reservation based on trainer avaliable time.
    public bool AddSessionReservation(int memberId, int trainerId, DateTime sessionDate, List<Trainer> trainers)
    {
        // Find the trainer by ID
        var trainer = trainers.FirstOrDefault(t => t.TrainerId == trainerId);
        if (trainer == null || !trainer.IsAvailableAt(sessionDate))
        {
            Console.WriteLine("Trainer is not available at this time.");
            return false; // Trainer not found or not available
        }

        // Check for time conflicts with existing sessions
        bool hasConflict = sessions.Any(s => s.TrainerId == trainerId && s.SessionDate == sessionDate);
        if (hasConflict)
        {
            Console.WriteLine("Time conflict with another session.");
            return false;
        }

        // Add the new session
        var newSession = new Session(sessionDate, memberId, trainerId);
        sessions.Add(newSession);
        return true;
    }
}
