using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Model
{
    public class Courts
    {
        public class Courts<T> where T : Court
        {
            public List<T> CourtsList { get; set; }

            public Courts()
            {
                CourtsList = new List<T>();
            }

            // 这里可以添加更多通用的方法和属性
        }

    }
}
