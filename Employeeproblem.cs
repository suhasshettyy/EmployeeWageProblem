using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
    class Employeeproblem
    {
        public int Condition()
        {
            int emphours = 0;
            int wageperhour = 20;
            int workingdayspermonth = 20;
            int wagespermonth = 0;
            int totalworkinghoursinamonth = 100;
            int totalworkingdays = 0;
            int employeehrinmonth = 0;
            while (employeehrinmonth <= totalworkinghoursinamonth && totalworkingdays <= workingdayspermonth)
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
                        emphours = 4;
                        break;
                }
                employeehrinmonth = employeehrinmonth + emphours;
            }
            wagespermonth = wageperhour * employeehrinmonth;
            Console.WriteLine(wagespermonth);
            return wagespermonth;
        }
    }
}