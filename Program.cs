using System;

namespace CodeWithIssues
{
    public class Program
    {

        public static void Main()
        {
            const string MsgWelcome = "Benvingut al programa de càlculs!";
            const string MsgEnd = "Finalitzant el programa...";


            Console.WriteLine(MsgWelcome);

            int numOne = 5;
            int numTwo = 14;
            int numThree = 15;

            int result = CalculateResult(numOne, numTwo, numThree);
            string msgResult = ShowMsg(result);

            Console.WriteLine(msgResult);
            Console.WriteLine(MsgEnd);
        }
        public static int CalculateResult(int numOne, int numTwo, int numThree)
        {
            int result = 0;
            if (numOne > 0 && numTwo > 0 && numThree > 0)
            {
                result = numOne + numTwo + numThree;
            }
            else if (numOne > 0 && numTwo > 0 && numThree <= 0)
            {
                result = numOne + numThree;
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
