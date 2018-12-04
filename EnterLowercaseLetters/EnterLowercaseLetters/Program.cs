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
            string letterString;
            WriteLine("Enter a letter: ");
            letterString = ReadLine();
            letter = Convert.ToChar(letterString);

            if (letter >= 'a' && letter <= 'z')
            {
                WriteLine(letter + " is OK");
            }
            else
                WriteLine("Error");

        }
    }
}
