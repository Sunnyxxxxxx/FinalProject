using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
        public Member()
    {

         if (Age < 6)
        {
            Console.WriteLine("Age must be 6 or above to be a member.");
            return;
        }
        else if (Age < 18)
        {
            Console.WriteLine("You must add emergency contact");
        
        }


        MemberID = ++account;
    }
    public void SetEmergencyContact(string emergencyContact)
    {
        if (Age < 18)
        {
            EmergencyContact = emergencyContact;
        
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
