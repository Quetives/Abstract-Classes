﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_176
{
    public abstract class Person
    {
        public string firstName;
        public string lastName;

        public virtual string SayName()
        {
            Console.WriteLine("Name:{0} {1}", firstName, lastName);
            return null;
        }
    }
}
