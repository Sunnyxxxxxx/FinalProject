using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model;

public class Members
{
    public List<Member> members { get; set; }

    public Members()
    {
        members = new List <Member> ();
    }

    public Member Authenticate(int memberId, string password)
    {
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
