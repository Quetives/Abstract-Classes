using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_176
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeOne = new Employee() { firstName = "Sample", lastName = "Student" };
            employeeOne.SayName();
            Console.ReadLine();
        }
    }
}
