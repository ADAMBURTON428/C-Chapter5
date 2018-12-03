using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace EnterLowercaseLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            string inputString;
            WriteLine("Enter A letter: ");
         
            letter = Convert.ToChar(inputString);
           
            if(letter >= 'a' && letter <= 'z')
            {
                WriteLine("OK");
            }

        }
    }
}
