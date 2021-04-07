using System;

namespace PracticeProblem
{      /* UC5.:- Calculating Wages for a Month
                - Assume 20 Working Day per Month
       */
    class EmployeeWageComputationProblem
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUM_OF_WORKING_DAYS =20;


        public static void Main(string[] args)      //Main method
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            Random random = new Random();       //Random Class
            for (int Day = 0; Day < NUM_OF_WORKING_DAYS; Day++)
            {


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

                empWage = EMP_RATE_PER_HOUR * emphrs;            // Calculate empWage
                   //Display empwage
                totalempwage = totalempwage + empWage;      //Calculate total employe month wage
            }
            Console.WriteLine("Employe Wage Per Day :- " + empWage);
            Console.WriteLine("Total Employe Month Wage :- "+ totalempwage);
        }
    }
}
