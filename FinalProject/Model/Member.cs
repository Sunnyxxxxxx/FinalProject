using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Member
    {
        private static int acount;
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public int MemberID { get; set; }
        public int password { get; set; }
        public int Pnumber { get; set; }
        public string address { get; set; }
        public string Gender { get; set; }
        public int EmergcyC {  get; set; }



        public Member()
        {
            MemberID++;
            acount = MemberID;
        }

    }
}
