using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{       /*UC1:-  Check Employee is 
                 Present or Absent
                - Use ((RANDOM)) for Attendance Check
        */
    class UC1PresentAbsent
    {
        public void PresentorAbsent()
        {
            int PRESENT = 1;
            Random random = new Random();
            int EmpCheack = random.Next(0, 2);
            if (EmpCheack == 1)
            {
                Console.WriteLine("Employee Is Present");

            }
            else
            {
                Console.WriteLine("Employe Is Absent");
            }
        }

    }
}
