﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingNumAnonymous
{
    
    class Program
    {
        public delegate int sum(int i, int j);
        static void Main(string[] args)
        {
            int result;
            sum s = delegate (int i,int j)
            {
                return i + j;
            };
            result = s(10, 20);
            Console.WriteLine(result);


        }
    }
}
