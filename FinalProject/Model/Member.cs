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
    private string EmergencyContact { get; set; } 
    private static int account = 1000;

    public Member(int age)
    {

    }
    public void InitializeMember (int age)
    {
        Age = age;

        if (Age < 6)
        {
            Console.WriteLine("Age must be 6 or above to be a member.");
            return;
        }
        else if (Age < 18)
        {
            Console.WriteLine("You must add emergency contact.");
        }

        MemberId = ++account;
    }



    public void SetEmergencyContact(string emergencyContact)
    {
        if (Age < 18)
        {
            EmergencyContact = emergencyContact;
            Console.WriteLine("Emergency contact added for member under 18.");
        }
        else
        {
            Console.WriteLine("Emergency contact is not required for members 18 and older.");
        }
    }

    public string GetEmergencyContact()
    {
        if (Age < 18)
        {
            return EmergencyContact;
        }
        else
        {
            return "Not Applicable";
        }
    }

    
}