﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structDemo
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number();
            num.Amount = 16.123123m;
            
            Console.WriteLine(num.Amount);
            Console.Read();
        }
    }
}
