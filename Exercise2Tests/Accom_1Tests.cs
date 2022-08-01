using Exercise1;

namespace Exercise2Tests
{
    public class Accom_1Tests
    {
        [Fact]
        public void Validate_True()
        {
            // Arrange
            var testLearner = new Exercise1.Learner
            {
                FamilyName = "Sterling",
                GivenNames = "Ann",
                LearnRefNumber = "Ref789",
                Accom = 1
            };

            // Act & Assert
            Assert.Equal(1,testLearner.Accom);
        }

        [Fact]
        public void Validate_Accom_01_False()
        {
            // Arrange
            var testLearner = new Exercise1.Learner
            {
                FamilyName = "Kayne",
                GivenNames = "Rob",
                LearnRefNumber = "Ref456",
                Accom = 0
            };

            // Act & Assert
            Assert.Equal(0, testLearner.Accom);
        }
    }
}
