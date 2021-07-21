using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeeproblem
    {
        public void Attendance()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 1)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}