using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Member
{
    public int MemberId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Password { get; set; }

    private static int account = 1000;

    private Member(int age)
    {

    }
    public static Member CreateMember(string firstName, string lastName, string password, int age)
    {
        if (age < 6)
        {
            Console.WriteLine("Age must be 6 or above to be a member.");
            return null;
        }

        var newMember = new Member (age)
        {
            FirstName = firstName,
            LastName = lastName,
            Password = password,
            Age = age,
            MemberId = ++account
        };

        return newMember;
    }

    
}