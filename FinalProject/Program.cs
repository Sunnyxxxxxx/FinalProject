using FinalProject.Model;
using System.Security.Cryptography.X509Certificates;

namespace FinalProject;

public class Program
{
    private static Member authenticatedMember;
    private static Members members;
    private static Member member;
    static void Main(string[] args)
    {
     
        static void Initialize()
        {
            var m1 = new Member (21)
            {
                FirstName = "Qian",
                LastName = "Tong",
                Password = "1234"
            };
            var m2 = new Member(22)
            {
                FirstName = "Xiayi",
                LastName = "Wang",
                Password = "3478"
            };
            var m3 = new Member (23)
            {
                FirstName = "Jiayang",
                LastName = "Xu",
                Password = "1243"
            };
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
                        GetMenu();
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
            string LastName = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = Convert.ToInt32(Console.ReadLine());

            

            var newMember = new Member (age)
            {
                FirstName = firstName,
                LastName = LastName,
                Password = password
            };

            newMember.InitializeMember(age);

            members.members.Add(newMember);

            Console.WriteLine("Profile created!");

        }
    }
}