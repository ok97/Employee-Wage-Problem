﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{       /* UC3:- Add Part time 
                 Employee & Wage
                 - Assume Part time Hour is 8
        */
    class UC3ParttimeEmployeeWage
    {   
        public void ParttimeEmployeeWage()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empWage = 0;
            Random random = new Random();
            int EmpCheack = random.Next(0, 3);
            if (EmpCheack == FULL_TIME)
            {
                emphrs = 8;

            }
            else if (EmpCheack == PART_TIME)
            {
                emphrs = 4;
            }
            else
            {
                emphrs = 0;
            }
            empWage = EMP_RATE_PER_HOUR * emphrs;
            Console.WriteLine("Employe Wage Per Day:- " + empWage);
        }
    }
}