using JenkinsCatsLibrary;
namespace UnitTesting
{
    public class JenkinsCatsXUnitTests
    {
        [Theory]
        [InlineData(0, 0, 0, 0)]
        [InlineData(1, 0, 0, 1)]
        [InlineData(1, 1, 0, 2)]
        [InlineData(1, 1, 1, 3)]
        public void CalculateResult_Tests(int numOne, int numTwo, int numThree, int expected)
        {
            // Act
            int result = JenkinsCatsClass.CalculateResult(numOne, numTwo, numThree);

            // Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0, "El resultat és zero.")]
        [InlineData(10, "El resultat és positiu.")]
        [InlineData(-3, "El resultat és negatiu.")]
        public void ShowMsg_Tests(int result, string expectedMsg)
        {
            // Act
            string msg = JenkinsCatsClass.ShowMsg(result);

            // Assert
            Assert.Equal(expectedMsg, msg);
        }
    }
}
