using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeeproblem
    {
        public static int Company(string companyname, int wageperhour, int workingdayspermonth, int totalworkinghoursinamonth)
        {
            int emphours = 0;
            int wagespermonth = 0;
            int totalworkingdays = 0;
            int employeehrinmonth = 0;
            while (employeehrinmonth < totalworkinghoursinamonth && totalworkingdays < workingdayspermonth)
            {
                totalworkingdays++;
                Random random = new Random();
                int empcheck = random.Next(0, 2);
                switch (empcheck)
                {
                    case 0:
                        emphours = 8;
                        break;
                    case 1:
                        emphours = 8;
                        break;
                }
                employeehrinmonth = employeehrinmonth + emphours;
            }
            wagespermonth = wageperhour * employeehrinmonth;
            Console.WriteLine("Company name is " + companyname + " and total wage is " + wagespermonth);
            return wagespermonth;
        }
    }
}