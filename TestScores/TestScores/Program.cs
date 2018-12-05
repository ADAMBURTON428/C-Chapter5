using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace TestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MAX = 100;
            const int MIN = 0;
            int ScoreNumber = 0;
            int Test = 0;
            string TestString;
            int average = 0;
            int Total= 0;
            while (Test != 999)
            {

                WriteLine("Enter a Test Score or 999 to exit >>>>");
                TestString = ReadLine();
                Test = Convert.ToInt32(TestString);
                if (Test > MIN && Test < MAX)
                {
                    Total = Total + Test;
                    ScoreNumber++;
                       
                   
                }
                else if (Test == 999)
                {
                    average = Total / ScoreNumber;
                    Write("The average is " + average + " out of " + ScoreNumber + " Scores");


                }
            }
             
            
        }
    }
}
