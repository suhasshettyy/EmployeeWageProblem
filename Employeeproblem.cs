using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageProblem
{
        class EmployeeWageBuilder
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int empHrs = 0;
            public int totalEmpHrs = 0;
            public int totalWorkingDays = 0;
            public int totalEmpWage = 0;
            public EmployeeWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public int ComputeEmpWage()
            {
                while (totalEmpHrs < maxHoursPerMonth &&
                        totalWorkingDays < numOfWorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int empCheck = random.Next(0, 3);
                    switch (empCheck)
                    {
                        case IS_FULL_TIME:
                            empHrs = 8;
                            break;
                        case IS_PART_TIME:
                            empHrs = 8;
                            break;
                        default:
                            empHrs = 0;
                            break;
                    }
                    totalEmpHrs += empHrs;
                    Console.WriteLine("Day " + totalWorkingDays + "\nEmp Hr: " + empHrs);
                }
                totalEmpWage = totalEmpHrs * empRatePerHour;
                return totalEmpWage;
            }
        }
    }