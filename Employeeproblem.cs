using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeeproblem
    {
        public void Usingcase()
        {
            Random random = new Random();
            int wageprhr = 20;
            int hr = 8;
            int parttimehr = 8;
            int x = wageprhr * hr;
            int y = wageprhr * (hr + parttimehr);
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    {
                        Console.WriteLine("Employee is Present");
                        Console.WriteLine("Employee Wage is:" + x.ToString());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Employee Parttime Wage is:" + y.ToString());
                        break;

                    }
            }

        }
    }
}