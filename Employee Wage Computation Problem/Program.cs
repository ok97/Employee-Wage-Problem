using System;

namespace Employee_Wage_Computation_Problem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("********* Choice Any One Program *********\n\n"+
                "1. UC1 Check Employee is Present or Absent - Use((RANDOM)) for Attendance Check)\n"+
                "2. UC2:-Calculate Daily Employee Wage- Assume Wage per Hour is 20- Assume Full Day Hour is 8\n"+
                "3. UC3:- Add Part time Employee & Wage- Assume Part time Hour is 8\n"+
                "4. UC4:- Solving using Switch Case Statement\n"+
                "5. UC5 :- Calculating Wages for a Month- Assume 20 Working Day per Month\n"+
                "6. UC6 :- Calculate Wages till a condition of total working hours or days is reached for a\n   month- Assume 100 hours and 20 days\n"+
                "7. UC7:- Refactor the Code to write a Class Method to Compute Employee Wage\n"+
                "8. UC8:- Ability to compute EmployeeWageformultiple companies\n"+
                "9. UC9:- Ability to save the Total Wage for Each Company\n"+
                "Enter Your Choice:- ") ;
            int Number = Convert.ToInt32(Console.ReadLine());
            switch (Number)
            {
                case 1:
                    UC1PresentAbsent PA = new UC1PresentAbsent();
                    PA.PresentorAbsent();
                    Console.Read();
                    break;

                case 2:
                    UC2DailyEmployeeWage EmpWage = new UC2DailyEmployeeWage();
                    EmpWage.EmployeeWage();
                    Console.Read();
                    break;

                case 3:
                    UC3ParttimeEmployeeWage parttimeempwage = new UC3ParttimeEmployeeWage();
                    parttimeempwage.ParttimeEmployeeWage();
                    Console.Read();
                    break;

                case 4:
                    UC4SwitchCaseStatement.SwitchCaseStatement();
                    Console.ReadLine();
                    Console.Read();
                    break;

                case 5:
                    UC5WagesforaMonth.WageForMonth();
                    Console.ReadLine();
                    Console.Read();
                    break;
                case 6:
                    UC6Wagestillacondition.Wagestillacondition();
                    Console.ReadLine();
                    Console.Read();
                    break;

                case 7:
                    UC7RefactortheCode.ComputeEmployeeWage();
                    Console.ReadLine();
                    Console.Read();
                    break;
                        case 8:
                    UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Dmart", 20, 2, 10);
                    UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Walmart", 20, 20, 50);
                    UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Freshmart ", 10, 6, 40);
                    UC8EmployeeWageformultiplecompanies.ComputeEmployeeWage("Budget Foods", 20, 4, 10);
                    Console.ReadLine();
                    break;

                case 9:
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
                    break;

            }
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


            //UC9SavetheTotalWageforEachCompany dmart = new UC9SavetheTotalWageforEachCompany("Dmart", 20, 2, 10);
            //UC9SavetheTotalWageforEachCompany walmart = new UC9SavetheTotalWageforEachCompany("Walmart", 20, 20, 50);
            //UC9SavetheTotalWageforEachCompany fresht = new UC9SavetheTotalWageforEachCompany("Freshmart ", 10, 6, 40);
            //UC9SavetheTotalWageforEachCompany budget = new UC9SavetheTotalWageforEachCompany("Budget Foods ", 20, 4, 10);
            //dmart.ComputeEmployeeWage();
            //Console.WriteLine(dmart.toString());
            //walmart.ComputeEmployeeWage();
            //Console.WriteLine(walmart.toString());
            //fresht.ComputeEmployeeWage();
            //Console.WriteLine(fresht.toString());
            //budget.ComputeEmployeeWage();
            //Console.WriteLine(budget.toString());
            //Console.ReadLine();


            //Console.WriteLine("Hello World!");
        }
    }
}
