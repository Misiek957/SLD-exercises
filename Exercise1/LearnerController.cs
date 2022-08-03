using ESFA.DC.Serialization.Json;

namespace Exercise1
{
    public class LearnerController
    {
        string jsonFilenameHardcoded = "C:/dev/exercise/Exercise1/Exercise1/Learners/LearnersData.json"; // TODO: Hardcoded
        string jsonFileNameTargetHardcoded = "C:/dev/exercise/Exercise1/Exercise1/Learners/ExportedLearnersData.json"; // TODO: Hardcoded
        public List<Learner> ImportLearnerJson()
        {
            
            //Console.WriteLine(jsonFilenameHardcoded);
            string jsonText = File.ReadAllText(this.jsonFilenameHardcoded);
            var jsonService = new JsonSerializationService();
            var importedlearners = jsonService.Deserialize<List<Learner>>(jsonText);
            return importedlearners;
        }

        public void ExportLearnerJson(List<Learner> learners)
        {
            var jsonService = new JsonSerializationService();
            var jsonString = jsonService.Serialize(learners);
            File.WriteAllText(this.jsonFileNameTargetHardcoded, jsonString);
            Console.WriteLine("\nLearners data exported successfully  ");
        }

        public static string GetDisplayName(Learner learner)
        {
            if (learner.FamilyName != null && learner.FamilyName != null)
            {
                string displayName = learner.GivenNames + " " + learner.FamilyName;
                return displayName;
            }
            else
            {
                string displayName = "INVALID NAME";
                return displayName;
            }
        }
    }
}
