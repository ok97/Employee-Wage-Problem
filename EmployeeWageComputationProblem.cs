using System;

namespace PracticeProblem
{       /* Check Employee is 
           Present or Absent
           - Use ((RANDOM)) for Attendance Check
        */
    class EmployeeWageComputationProblem
    {
        static void Main(string[] args)
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
