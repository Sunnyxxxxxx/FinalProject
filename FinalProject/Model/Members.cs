using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

//Declare a Members class
public class Members
{
    // A property to store a list of Members.
    public List<Member> members { get; set; }

    // A constructor for the Members class and set the members list.
    public Members()
    {
        members = new List <Member> ();
    }

    // A method to authenticate a member with their memberId and password.
    public Member Authenticate(int memberId, string password)
    {
        // Check if the member is matching with thw system.
        var m = members.Where(r => (r.MemberId == memberId) && (r.Password == password));
        if(m.Count() > 0)
            {
            return m.First();
            }
                else
            {
                return null;
            }


    }
}
