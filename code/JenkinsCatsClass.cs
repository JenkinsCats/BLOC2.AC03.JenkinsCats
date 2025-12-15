namespace JenkinsCatsLibrary
{
    public class JenkinsCatsClass
    {
        // This function calculates a result based on the values of three integer parameters.
        // It sums the numbers according to specific conditions:
        // - If all three numbers are positive, it sums all three.
        // - If numOne and numTwo are positive but numThree is zero or negative, it sums numOne and numThree.
        // - If only numOne is positive, it returns numOne.
        // - If numOne is zero or negative, it returns 0.
        public static int CalculateResult(int numOne, int numTwo, int numThree)
        {
            int result = 0;
            if (numOne > 0 && numTwo > 0 && numThree > 0)
            {
                result = numOne + numTwo + numThree;
            }
            else if (numOne > 0 && numTwo > 0 && numThree <= 0)
            {
                result = numOne + numTwo;
            }
            else if (numOne > 0 && numTwo <= 0)
            {
                result = numOne;
            }
            else if (numOne <= 0)
            {
                result = 0;
            }
            return result;
        }
        // This function returns a message based on the value of the integer parameter 'result':
        // - If result is 0, it returns "El resultat és zero."
        // - If result is greater than 0, it returns "El resultat és positiu."
        // - If result is less than 0, it returns "El resultat és negatiu."
        public static string ShowMsg(int result)
        {
            string msgResult = "";
            if (result == 0)
            {
                msgResult = "El resultat és zero.";
            }
            else if (result > 0)
            {
                msgResult = "El resultat és positiu.";
            }
            else
            {
                msgResult = "El resultat és negatiu.";
            }
            return msgResult;
        }
    }
}
