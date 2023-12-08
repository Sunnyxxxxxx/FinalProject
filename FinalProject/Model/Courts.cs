using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Courts
    {
        public class AllCourts<T> where T : Court
        {//the allcourts generic provides a list to mannage court objects that inherit from the court class and list that stores the collection
            public List<T> CourtsList { get; set; }

            public AllCourts()//constructor that initializes the courtslist as ann empty list ready to store court objects
            {
                CourtsList = new List<T>();
            }

        }

    }
}
