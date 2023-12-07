using FinalProject.Model;
using System.Security.Cryptography.X509Certificates;

namespace FinalProject;

public class Program
{
    private static Member authenticatedMember;
    private static Members members;
    private static Member member;
    private static TennisCourts tennisCourts;
    private static BasketballCourts basketballCourts;
    private static Reservations reservations;
    static void Main(string[] args)
    {
        Initialize();
        Menu();
    }

        static void Initialize()
        {
            var m1 = Member.CreateMember("Qian", "Tong", "1234", 21);
            var m2 = Member.CreateMember("Xiayi", "Wang", "3478", 22);
            var m3 = Member.CreateMember("Jiayang", "Xu", "1243", 23);

            // Here, you can add these members to a Members collection or process them further
        }


        static void Menu()
        {
            bool done = false;

            while (!done)
            {
                Console.WriteLine("Welcome to Fitness Center! Thank you for choosing us.");
                Console.WriteLine("Please log in to your account.");
                Console.WriteLine("Options: Login: 1 --- Logout: 2 --- Sign Up: 3 --- Reservation: 4 --- Clear Screen: c --- Quit: q ---");
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
                        MakeTrainerReservation();
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

        static void LoginMenu()
        {
            if (authenticatedMember == null)
            {
                Console.Write("Enter your member Id: ");
                string MemberIdInput = Console.ReadLine();
                int memberId = Convert.ToInt32 (MemberIdInput);
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

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
            else
            {
                Console.WriteLine($"You are already logged in as {authenticatedMember.MemberId}");
            }
        }

        static void LogoutMenu()
        {
            authenticatedMember = null;
            Console.WriteLine("Logged out!");
        }

        static void SignUpMenu()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            var newMember = Member.CreateMember(firstName, lastName, password, age);


            if (newMember != null)
            {
                members.members.Add(newMember);
                Console.WriteLine($"Profile created! Your Member ID is {newMember.MemberId}.");
            }

        }
        static void MakeTrainerReservation()
        {
            if (authenticatedMember == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }
            foreach (var trainer in Trainers.)
            {
                Console.WriteLine($"Trainer ID: {trainer.TrainerId}, Name: {trainer.TrainerName}");
            }

        }

        static void MakeCourtReservation()
        {
            if (authenticatedMember == null)
            {
                Console.WriteLine("You are not logged in.");
                return;
            }

            Console.Write("Enter your Member ID: ");
            int memberId;
            if (!int.TryParse(Console.ReadLine(), out memberId) || memberId != authenticatedMember.MemberId)
            {
                Console.WriteLine("Invalid Member ID.");
                return;
            }

            Console.WriteLine("Choose court type: 1 for Tennis, 2 for Basketball");
            int courtType;
            if (!int.TryParse(Console.ReadLine(), out courtType) || (courtType != 1 && courtType != 2))
            {
                Console.WriteLine("Invalid Court Type.");
                return;
            }

            Console.Write("Enter Court ID to reserve: ");
            int courtId;
            if (!int.TryParse(Console.ReadLine(), out courtId))
            {
                Console.WriteLine("Invalid Court ID.");
                return;
            }

            Court court = null;
            if (courtType == 1) // 网球场
            {
                if (!tennisCourts.tenniscourts.Any(c => c.CourtID == courtId))
                {
                    Console.WriteLine("Invalid Tennis Court ID.");
                    return;
                }
                court = tennisCourts.tenniscourts.First(c => c.CourtID == courtId);
            }
            else if (courtType == 2) // 篮球场
            {
                if (!basketballCourts.basketballcourts.Any(c => c.CourtID == courtId))
                {
                    Console.WriteLine("Invalid Basketball Court ID.");
                    return;
                }
                court = basketballCourts.basketballcourts.First(c => c.CourtID == courtId);
            }

            Console.Write("Enter reservation date and time (yyyy-mm-dd hh:mm): ");
            DateTime reservationDate;
            if (!DateTime.TryParse(Console.ReadLine(), out reservationDate))
            {
                Console.WriteLine("Invalid date and time format.");
                return;
            }

        reservations.AddCourtReservation(authenticatedMember.MemberId, courtId, reservationDate, court);

    }

}