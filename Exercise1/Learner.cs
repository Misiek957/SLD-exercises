using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Learner
    {
        public string FamilyName { get; set; }
        public string GivenNames { get; set; }
        public string LearnerRefNumber { get; set; }
        public int? Accom { get; set; }

        public static void Hello()
        {
            Console.WriteLine("Hello from inside class");
        }
    }
}
