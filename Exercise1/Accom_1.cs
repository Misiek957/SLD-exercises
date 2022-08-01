using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Accom_1
    {
        public static void CheckLearnerValidity (Learner learnerToCheck)
        {
            if (learnerToCheck.Accom == 1)
            {
                Console.WriteLine("This learner is valid");
            } else
            {
                Console.WriteLine("This learner is invalid");
            }
        }
    }
}
