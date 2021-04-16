using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{           /* UC8:- Ability to compute EmployeeWageformultiple companies */
    class UC8EmployeeWageformultiplecompanies
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;
        // public const int EMP_RATE_PER_HOUR = 20;
        //public const int MAX_WORKING_HRS = 100;
        // public const int MAX_WORKING_DAYS = 20;
        public static int ComputeEmployeeWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            Random random = new Random();       //Random Class
            while (hrs < empRatePerHour && numOfWorkingDays <= maxHoursPerMonth)
            // for (int Day = 0; Day < NUM_OF_WORKING_DAYS; Day++)
            {

                workingDays++;
                int EmpCheack = random.Next(0, 3);      //Random Generate 0 ,1,2
                switch (EmpCheack)          //Switch case Statment
                {
                    case FULL_TIME:         //Employee is FullTime=1
                        emphrs = 8;
                        break;
                    case PART_TIME:          //Employee is FullTime=2
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                // Calculate empWage
                hrs += emphrs;                                           //Display empwage
                totalempwage = totalempwage + empWage;      //Calculate total employe month wage
                empWage = empRatePerHour * emphrs;
            }

            Console.WriteLine($"Toatal Emp wage for company:- {company} is {totalempwage}");
            Console.WriteLine("Employe Wage Per Day :- " + empWage);
            //Console.WriteLine("Total Employe Month Wage :- " + totalempwage);
            //  Console.WriteLine("Employee wage for " + workingDays + " days " + totalempwage);
            Console.WriteLine("Working hours " + hrs + "\n");
            return totalempwage;

        }
        static void Main(String[] args)
        {
            ComputeEmployeeWage("Dmart", 20, 2, 10);
            ComputeEmployeeWage("Walmart", 20, 20, 50);
            ComputeEmployeeWage("Freshmart ", 10, 6, 40);
            ComputeEmployeeWage("Budget Foods", 20, 4, 10);
        }
    }
}