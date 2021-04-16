using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblem
{
    /*UC11 To 14  UC11 Ability to manage Employee Wage of multiple companies using API approach
      UC12 Refactor to have list of multiple companies to manage Employee Wage.
      UC13 Store the Daily Wage along with the Total Wage.
      UC14 Ability to get the Total Wage when queried by Company.
    */
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int getTotalWage(string company);

    }
    public class EmployeeWageComputationProblem
    {
        public string company;
        public int empRatePerHour;
        public int numOfWorkingDays;
        public int maxHoursPerMonth;
        public int totalempwage;
        internal int totalEmpWage;

        public EmployeeWageComputationProblem(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
            this.totalempwage = 0;
        }
        public void setTotalEmpwage(int totalEmpWage)
        {
            this.totalempwage = totalEmpWage;
        }
        public string toString()
        {
            return "Total Emp Wage for company :- " + company + " is :- " + totalempwage;
        }
    }
    public class EmpWageBuilder : IComputeEmpWage
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;

        private LinkedList<EmployeeWageComputationProblem> companyEmpWageList;
        private Dictionary<string, EmployeeWageComputationProblem> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<EmployeeWageComputationProblem>();
            this.companyToEmpWageMap = new Dictionary<string, EmployeeWageComputationProblem>();
        }
        public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            EmployeeWageComputationProblem companyEmpWage = new EmployeeWageComputationProblem(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void ComputeEmployeeWage()
        {
            foreach (EmployeeWageComputationProblem companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpwage(this.ComputeEmployeeWage(EmployeeWageComputationProblem));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int ComputeEmployeeWage(EmployeeWageComputationProblem companyEmpWage)
        {
            int emphrs = 0;
            int empWage = 0;
            int totalempwage = 0;
            int hrs = 0;
            int workingDays = 1;
            while (emphrs <= companyEmpWage.maxHoursPerMonth && workingDays < companyEmpWage.numOfWorkingDays)
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

                Console.WriteLine("Day " + workingDays + " Emp hrs:- " + emphrs);

                //totalempwage = totalempwage + empWage;      //Calculate total employe month wage
                //empWage = empRatePerHour * emphrs;

            }
            return emphrs * companyEmpWage.empRatePerHour;
        }
        public int getTotalWage(string company)
        {
            return this.companyToEmpWageMap[company].totalEmpWage;
        }

        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            throw new NotImplementedException();
        }

        public void ComputeEmpWage()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        public static void Main(String[]args)
        {
            EmpWageBuilder epWageBuilder = new EmpWageBuilder();   //Create object of class
            epWageBuilder.addComapnyEmpWage("Dmart", 20, 2, 10);  //call method
            epWageBuilder.addComapnyEmpWage("Reliance", 10, 4, 20); //call method
            epWageBuilder.ComputeEmployeeWage();  //call method
            Console.WriteLine("Totsl Wage For Dmart Comapny :- " + epWageBuilder.getTotalWage("Dmart"));
        }
    }
}