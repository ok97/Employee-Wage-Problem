using System;

namespace PracticeProblem
{       /*UC2.:- Calculate Daily 
                 Employee Wage  
                 - Assume Wage per Hour is 20 
                 - Assume Full Day Hour is 8
        */
    class EmployeeWageComputationProblem
    {
        static void Main(string[] args)
        {
            int PRESENT = 1;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int EmpCheack = random.Next(0, 2);
            if (EmpCheack == PRESENT)
            {
                emphrs = 8;

            }
            else
            {
                emphrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * emphrs;
            Console.WriteLine("Employe Wage Per Day:- "+ empWage);
        }
    }
}
