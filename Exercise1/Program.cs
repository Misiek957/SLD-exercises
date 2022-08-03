using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Import Learner json data
            Console.WriteLine("Starting...\n");
            var learnerController = new LearnerController();


            // Import Learner json Data
            var importedLearners = learnerController.ImportLearnerJson();
            foreach (var learner in importedLearners)
            {
                Accom_1.CheckLearnerValidity(learner);
            }


            // Export Learner json Data
            var exportLearners = new List<Learner>();
            Learner customLearner1 = CreateCustomLearner("Mary", "Sterling", "ref123", 1);
            exportLearners.Add(customLearner1);
            Learner customLearner2 = CreateCustomLearner("George", "Smith", "ref456", 0);
            exportLearners.Add(customLearner2);

            learnerController.ExportLearnerJson(exportLearners);
        }

        private static Learner CreateCustomLearner(string firstName, string lastName, string reference, int accom)
        {
            var customLearner = new Learner
            {
                FamilyName = lastName,
                GivenNames = firstName,
                LearnRefNumber = reference,
                Accom = accom
            };

            return customLearner;
        }
    }

}


