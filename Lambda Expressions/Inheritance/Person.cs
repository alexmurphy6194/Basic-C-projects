﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Person
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
