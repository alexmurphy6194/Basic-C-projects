﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person
    {
        public override void sayName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }

    }
}
