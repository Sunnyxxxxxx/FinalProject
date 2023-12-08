using FinalProject.Model;
using System.Security.Cryptography.X509Certificates;

namespace FinalProject;

// This program represents a Fitness Center management system that allows members to log in, sign up, make court reservations, 
// and book training sessions with available trainers.
public class Program
{
    // variable data field
    private static Member authenticatedMember;
    private static Member member;
    private static Members members;
    private static TennisCourt tennisCourt;
    private static TennisCourts tennisCourts;
    private static BasketballCourt basketballCourt;
    private static BasketballCourts basketballCourts;
    private static Reservation reservation;
    private static Reservations reservations;
    private static Trainer trainer;
    private static Trainers trainers;
    private static Session session;
    private static Sessions sessions;

    // Display the main menu and Initialize entities and data.
    static void Main(string[] args)
    {
        Initialize();
        Console.WriteLine("Welcome to Fitness Center! Thank you for choosing us.");
        Console.WriteLine("We are open from 6am to 10pm.");
        Menu();
    }

        // Initialize entities and data.
        static void Initialize()
        {
            members = new Members();
            reservations = new Reservations();
            trainers = new Trainers();
            sessions = new Sessions();
    }

        // The main menu where users can choose various options: log in, log out, sign up, reservation
        static void Menu()
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- CourtReservation: 4 --- SessionReservation: 5 --- Clear Screen: c --- Quit: q ---");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        LoginMenu();
                        break;
                    case "2":
                        LogoutMenu();
                        break;
                    case "3":
                        SignUpMenu();
                        break;
                    case "4":
                        MakeCourtReservation();
                        break;
                    case "5":
                        MakeSessionReservation();
                        break;
                    case "c":
                        Console.Clear();
                        break;
                    case "q":
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid command!");
                        break;
                }

            }
        }
        // Let member sign in.
        static void LoginMenu()
        {
            // check if user login already
            if (authenticatedMember == null)
            {//if user not login, ask them enter their their informtion
                Console.Write("Enter your member Id: ");
                string MemberIdInput = Console.ReadLine();
                int memberId = Convert.ToInt32 (MemberIdInput);
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
            //check if the member in the system
                authenticatedMember = members.Authenticate(memberId, password);
                if (authenticatedMember != null)
                {
                    Console.WriteLine($"Welcome {authenticatedMember.FirstName}");
                }
                else
                {
                    Console.WriteLine("invalid member Id or password");
                }
            }
            else//when already login
            {
                Console.WriteLine($"You are already logged in as {authenticatedMember.MemberId}");
            }
        }
        // The logout process.
        static void LogoutMenu()
        {
            authenticatedMember = null;
            Console.WriteLine("Logged out!");
        }
        // The signup process.
        static void SignUpMenu()
        {//ask users' information
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            //create member
            var newMember = Member.CreateMember(firstName, lastName, password, age);

            //put them in the list
            if (newMember != null)
            {
                members.members.Add(newMember);
                Console.WriteLine($"Profile created! Your Member ID is {newMember.MemberId}.");//tell them their memberID
            }

        }
        // The process of making a court reservation.
        static void MakeCourtReservation()
        {//check if member are logged in
            if (authenticatedMember == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }

            ShowMemberReservations();
            //Ask member which court they want choose
            Console.WriteLine("Choose court type (1 for Basketball; 2 for Tennis;):");
            int courtType;
            // check their court type 
            if (!int.TryParse(Console.ReadLine(), out courtType) || (courtType != 1 && courtType != 2))
            {
                Console.WriteLine("Invalid Court Type.");
                return;
            }
            //ask member to enter court Id 
            Console.Write("Enter Court ID to reserve (1,2,3,4 for Basketball; 5,6,7,8,9,10 for Tennis;): ");
            int courtId;
            // Check if member enter valid Id
            if (!int.TryParse(Console.ReadLine(), out courtId))
            {
                Console.WriteLine("Invalid Court ID.");
                return;
            }

            Court court = null;

            if (courtType == 1)// Check if the selected court type is basketball
        {
                var basketballCourts = new BasketballCourts();
                if (!basketballCourts.CourtsList.Any(c => c.CourtID == courtId))
                {// Check if there is a basketball court with the specified CourtID.
                Console.WriteLine("Invalid Basketball Court ID.");
                    return;
                }
                court = basketballCourts.CourtsList.First(c => c.CourtID == courtId);// If a basketball court with the specified CourtID exists
        }
            else if (courtType == 2) // Check if the selected court type is Tennis
        {
                var tennisCourts = new TennisCourts();
                if (!tennisCourts.CourtsList.Any(c => c.CourtID == courtId))
                {// Check if there is a tennis court with the specified CourtID.
                    Console.WriteLine("Invalid Tennis Court ID.");
                    return;
                }
                court = tennisCourts.CourtsList.First(c => c.CourtID == courtId);// If a tennis court with the specified CourtID exists
        }

            Console.Write("Enter reservation date and time (yyyy-mm-dd hh:mm): ");
            DateTime reservationDate;
            if (!DateTime.TryParse(Console.ReadLine(), out reservationDate))// Try to parse the user input as a DateTime.
        {
                Console.WriteLine("Invalid date and time format.");
                return;
            }

            if (reservations.AddCourtReservation(authenticatedMember.MemberId, courtId, reservationDate, court))
            {// Attempt to add the court reservation with courtId, reservationDate, and court.
                ShowMemberReservations();
            }
            else
        {// Display an error message if the reservation process failed.
            Console.WriteLine("Reservation failed.");
            }
        }
        // Show the member's current reservations.
        public static void ShowMemberReservations()
        {
            var memberReservations = reservations.GetReservationsByMemberId(authenticatedMember.MemberId);
            if (memberReservations.Count > 0)
            {// Check if the member has any reservations.
                Console.WriteLine("Your current reservations:");
                foreach (var reservation in memberReservations)
                {// Display the details of each reservation.
                    Console.WriteLine($"- Court ID: {reservation.CourtId}, Date: {reservation.ReservationDate}");
                }
            }
            else
            {// Tell the member if they have no reservations.
                Console.WriteLine("You have no reservations.");
            }
        }
        // The process of making a training session reservation.
        public static void MakeSessionReservation()
        {
            if (authenticatedMember == null)
            {// check if the member logged in
                Console.WriteLine("You are not logged in.");
                return;
            }

        Console.WriteLine("Available Trainers:");
        foreach (var trainer in trainers.trainers)
        {// Display available trainers and their information.
            Console.WriteLine($"ID: {trainer.TrainerId}, Name: {trainer.TrainerName}, Specialty: {trainer.Type}");
        }

        Console.Write("Enter the ID of the trainer you want to book: ");// Let the member to enter the ID of the trainer they want to book.
        if (!int.TryParse(Console.ReadLine(), out int trainerId) || !trainers.trainers.Any(t => t.TrainerId == trainerId))
        {// check if member enter right trainer Id
            Console.WriteLine("Invalid Trainer ID.");
            return;
        }
        // Let the member to enter the date and time for the session.
        Console.Write("Enter the date and time for your session (yyyy-mm-dd hh:mm): ");
        if (!DateTime.TryParse(Console.ReadLine(), out DateTime sessionDate))
        {//Check if they enter eright format for date and time
            Console.WriteLine("Invalid date and time format.");
            return;
        }

        if (sessions.AddSessionReservation(authenticatedMember.MemberId, trainerId, sessionDate, trainers.trainers))
        {// Attempt to add a session reservation using the MemberId, trainerId, sessionDate.
            Console.WriteLine("Session reservation successful!");
        }
        else
        {// Display an error message if the member enter wrong information
            Console.WriteLine("Reservation failed. Please check the trainer's availability.");
        }


    }



}