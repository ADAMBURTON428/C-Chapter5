﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OddNums
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 99; i++)
            {
                if (i == 1)
                {
                    WriteLine(i);
                }
                else
                    WriteLine(i + 2);
            }

        }
        }
    }
}
