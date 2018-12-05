using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            double danilleTotal = 0;
            double edwardTotal = 0;
            double francisTotal = 0;
            string input = null;


            while (input != "Z" || input != "z")
            {



                WriteLine("Input SalesPerson initial ");
                input = ReadLine();
               
                if ("F" == input || "f" == input)
                {
                    double saleHome = 0;
                    francisTotal = saleHome + francisTotal;
                    WriteLine(francisTotal);
                }
                else if ("D" == input || "d" == input)
                {
                    double saleHome = 0;
                    danilleTotal = saleHome + danilleTotal;
                    WriteLine(danilleTotal);
                }
                else if ("E" == input || "e" == input)
                {
                    double saleHome = 0;
                    edwardTotal = saleHome + edwardTotal;
                    WriteLine(edwardTotal);
                }
                else
                    WriteLine(edwardTotal);
                    WriteLine(danilleTotal);
                    WriteLine(francisTotal);
            }

            
        }
    }
}
