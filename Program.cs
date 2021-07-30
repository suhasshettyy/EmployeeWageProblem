using System;

namespace EmployeeWageProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            EmployeeWageBuilder employeeWageBuilderTCS = new EmployeeWageBuilder("TCS", 30, 28, 125);
            int dMartWage= employeeWageBuilderTCS.ComputeEmpWage();
            Console.WriteLine("TCS Total Wage:" + dMartWage);
            EmployeeWageBuilder employeeWageBuilderDell = new EmployeeWageBuilder("Dell", 25, 28, 125);
            int relianceWage= employeeWageBuilderDell.ComputeEmpWage();
            Console.WriteLine("Dell Total Wage:" + relianceWage);
        }
    }
}
