using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    class UC9SavetheTotalWageforEachCompany
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private string totalempwage;

        public UC9SavetheTotalWageforEachCompany(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;

        }
        public void ComputeEmployeeWage()
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            Random random = new Random();       //Random Class
            while (hrs < this.empRatePerHour &&this.numOfWorkingDays <= this.maxHoursPerMonth)
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

           // Console.WriteLine($"Toatal Emp wage for company:- {company} is {totalempwage}");
            Console.WriteLine("Employe Wage Per Day :- " + empWage);
            //Console.WriteLine("Total Employe Month Wage :- " + totalempwage);
            //  Console.WriteLine("Employee wage for " + workingDays + " days " + totalempwage);
            Console.WriteLine("Working hours " + hrs + "\n");
            //return totalempwage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + "is :- " + totalempwage ;
        }


    } 

}
