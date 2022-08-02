namespace Exercise1
{
    public class Accom_1
    {
        public static void CheckLearnerValidity (Learner learnerToCheck)
        {
            bool validityStatus = VerifyAccom(learnerToCheck);
            DisplayValidityMessage(validityStatus);
        }

        public static bool VerifyAccom(Learner learnerToCheck)
        {
            if (learnerToCheck.Accom == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void DisplayValidityMessage(bool validityStatus)
        {
            if (validityStatus)
            {
                Console.WriteLine("This learner is valid");
            }
            else
            {
                Console.WriteLine("This learner is invalid");
            }
        }
    }
}
