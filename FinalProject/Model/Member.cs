using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Member
{//public member class and holds personal details for members inn system, including an identifier name ,age , and password
    public int MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Password { get; set; }

    private static int account = 1000;

    private Member(int age)
    {// connstructor logic

    }
    public static Member CreateMember(string firstName, string lastName, string password, int age)
    {// static method to create a new member instance, enforcing a minimum age requirement
        if (age < 6)
        {
            Console.WriteLine("Age must be 6 or above to be a member.");
            return null;
        }

        var newMember = new Member (age)
        {// create a new member with the procided details and an auto account memberid
            FirstName = firstName,
            LastName = lastName,
            Password = password,
            Age = age,
            MemberId = ++account
        };

        return newMember;
    }

    
}