﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProject9
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (a*a + b*b == c*c)
                        {
                            if (a + b + c == 1000)
                            {
                                Console.WriteLine("{0} {1} {2}",a, b, c);
                                Console.WriteLine(a * b * c);
                            }
                        }
                    }
                }
            }
        }
    }
}
