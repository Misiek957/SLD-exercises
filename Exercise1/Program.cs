using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");
            Learner customLearner = CreateCustomLearner();
            Accom_1.CheckLearnerValidity(customLearner);
        }

        private static Learner CreateCustomLearner()
        {
            Learner customLearner = new Learner();
            customLearner.FamilyName = "Sterling";
            customLearner.GivenNames = "Maria";
            customLearner.LearnRefNumber = "ref123";
            customLearner.Accom = 1;
            return customLearner;
        }
    }

}


