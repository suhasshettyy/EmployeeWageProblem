using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeeproblem
    {
        public void Wage()
        {
            Random random = new Random();
            int wageprhr = 20;
            int hr = 8;
            int x = wageprhr * hr;
            int empcheck = random.Next(0, 2);
            if (empcheck == 0)
                Console.WriteLine("Employee is absent");
            else
            {
                Console.WriteLine("Employee is Present");
                Console.WriteLine("Employee Wage is:" + x.ToString());
            }
        }
    }
}