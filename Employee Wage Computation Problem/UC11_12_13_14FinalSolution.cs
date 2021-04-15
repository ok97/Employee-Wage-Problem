using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Wage_Computation_Problem
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
        public int getTotalWage(string company);

    }
    public class CompanyEmpWage
    {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalempwage;
        internal int totalEmpWage;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
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
    public class EmpWageBuilder: IComputeEmpWage
    {
        public const int FULL_TIME = 1;     //Constant variable
        public const int PART_TIME = 2;
       
        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmpWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }
        public void addComapnyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(company, companyEmpWage);
        }
        public void ComputeEmployeeWage()
        {
            foreach (CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.setTotalEmpwage(this.ComputeEmployeeWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        private int ComputeEmployeeWage(CompanyEmpWage companyEmpWage)
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
}