using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{           /* UC4:- Solving using 
                     Switch Case Statement
            */
    class UC4SwitchCaseStatement
    {       
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public static void SwitchCaseStatement()
        {
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();       //Random Class
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

            empWage = EMP_RATE_PER_HOUR * emphrs;       // Calculate empWage
            Console.WriteLine("Employe Wage Per Day:- " + empWage);     //Display empwage
        }
    }
}
