using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{       /* UC10 Ability to manage Employee Wage of multiple companies
        */
    class UC10ManageEmployeeWageofmultiplecompani
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalempwage;
        public UC10ManageEmployeeWageofmultiplecompani(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void setTotalEmpWage(int TotalEmpWage)
        {
            this.totalempwage = totalempwage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + " is :- " + totalempwage;
        }
    }
    public class EmpWageBuilderArray
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;

        public int numofCompany = 0;
        private UC10ManageEmployeeWageofmultiplecompani[] UC10ManageEmployeeWageofmultiplecompaniArray;

        public EmpWageBuilderArray()
        {
            this.UC10ManageEmployeeWageofmultiplecompaniArray = new UC10ManageEmployeeWageofmultiplecompani[5];
        }
        public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            UC10ManageEmployeeWageofmultiplecompaniArray[this.numofCompany] = new UC10ManageEmployeeWageofmultiplecompani(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numofCompany++;
        }
        public void ComputeEmployeeWage()
        {
            for (int i = 0; i < numofCompany; i++)
            {
                UC10ManageEmployeeWageofmultiplecompaniArray[i].setTotalEmpWage(this.ComputeEmployeeWage(this.UC10ManageEmployeeWageofmultiplecompaniArray[i]));
                Console.WriteLine(this.UC10ManageEmployeeWageofmultiplecompaniArray[i].toString());
            }
        }
        private int  ComputeEmployeeWage(UC10ManageEmployeeWageofmultiplecompani UC10ManageEmployeeWageofmultiplecompani)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            while (emphrs <= UC10ManageEmployeeWageofmultiplecompani.maxHoursPerMonth && workingDays < UC10ManageEmployeeWageofmultiplecompani.numOfWorkingDays)
            {

                workingDays++;
                Random random = new Random();
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
                hrs += emphrs;

                Console.WriteLine("Day "+ workingDays+ " Emp hrs:- "+ emphrs);//Display empwage

                //totalempwage = totalempwage + empWage;      //Calculate total employe month wage
                //empWage = empRatePerHour * emphrs;
               
            }
            return emphrs * UC10ManageEmployeeWageofmultiplecompani.empRatePerHour;

            


        }

    }
}
