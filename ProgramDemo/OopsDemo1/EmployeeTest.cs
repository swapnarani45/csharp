﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo1
{
    class EmployeeTest
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.GetBranchData();
            e1.GetEmployeeData();
            e1.DisplayBranchData();
            e1.DisplayEmployeeData();
            Console.ReadKey();
        }
    }
}
