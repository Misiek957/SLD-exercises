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
            var customLearner = new Learner
            {
                FamilyName = "Sterling",
                GivenNames = "Maria",
                LearnRefNumber = "ref123",
                Accom = 1
            };

            return customLearner;
        }
    }

}


