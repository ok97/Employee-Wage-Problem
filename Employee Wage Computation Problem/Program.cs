using System;

namespace Employee_Wage_Computation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1PresentAbsent PA = new UC1PresentAbsent();
            // PA.PresentorAbsent();

            //UC2DailyEmployeeWage EmpWage = new UC2DailyEmployeeWage();
            //EmpWage.EmployeeWage();

            //UC3ParttimeEmployeeWage parttimeempwage = new UC3ParttimeEmployeeWage();
            //parttimeempwage.ParttimeEmployeeWage();


            //UC4SwitchCaseStatement.SwitchCaseStatement();
            // Console.ReadLine();

            //UC5WagesforaMonth.WageForMonth();
            //Console.ReadLine();

            //UC6Wagestillacondition.Wagestillacondition();
            //Console.ReadLine();

            //UC7RefactortheCode.ComputeEmployeeWage();
            //Console.ReadLine();




            //UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Dmart", 20, 2, 10);
            //UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Walmart", 20, 20, 50);
            //UC8EmployeeWageformultiplecompanies. ComputeEmployeeWage("Freshmart ", 10, 6, 40);
            //UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Budget Foods", 20, 4, 10);
            //Console.ReadLine();


            UC9SavetheTotalWageforEachCompany dmart = new UC9SavetheTotalWageforEachCompany("Dmart", 20, 2, 10);
            UC9SavetheTotalWageforEachCompany walmart = new UC9SavetheTotalWageforEachCompany("Walmart", 20, 20, 50);
            UC9SavetheTotalWageforEachCompany fresht = new UC9SavetheTotalWageforEachCompany("Freshmart ", 10, 6, 40);
            UC9SavetheTotalWageforEachCompany budget = new UC9SavetheTotalWageforEachCompany("Budget Foods ", 20, 4, 10);
            dmart.ComputeEmployeeWage();
            Console.WriteLine(dmart.toString());
            walmart.ComputeEmployeeWage();
            Console.WriteLine(walmart.toString());
            fresht.ComputeEmployeeWage();
            Console.WriteLine(fresht.toString());
            budget.ComputeEmployeeWage();
            Console.WriteLine(budget.toString());
            Console.ReadLine();


            //Console.WriteLine("Hello World!");
        }
    }
}
