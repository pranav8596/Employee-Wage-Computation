using System;

namespace EmployeeWageProblem
{
    class EmployeeWageComputation
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        
        //Calculate total employee wage for a company 
        static void calculateEmpWages(String company, int empRatePerHour, int workingDaysPerMonth, int maximumWorkingHours)
        {
            //Variables
            int empHours = 0;
            int totalHours = 0;
            int days = 0;

            //To get a random number by using Random class
            Random random = new Random();

            //Calculate wages till days and hours reach to a limit
            while (days != workingDaysPerMonth && totalHours != maximumWorkingHours)
            {
                int empCheck = (int)Math.Floor(random.NextDouble() * 10) % 3;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalHours += empHours;
                days++;
            }
            int empWage = totalHours * empRatePerHour;
            Console.WriteLine("Employee wage for " + company + " is " + empWage);
        }
        static void Main(string[] args)
        {
            calculateEmpWages("Jio", 20, 22, 100);
            calculateEmpWages("Reliance", 30, 20, 90);
        }
    }
}
