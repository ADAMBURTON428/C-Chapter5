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
            int ScoreNumber = 0;
            int Test = 0;
            string TestString;
            int average = 0;

            while (Test != 999)
            {
                WriteLine("Enter a Test Score>>>>");
                TestString = ReadLine();
                Test = Convert.ToInt32(TestString);
                ScoreNumber++;
                average = Test / (ScoreNumber);
               
            }

            Write("The average is " + (average - 999));
        }
    }
}
