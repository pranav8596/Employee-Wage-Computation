using System;

namespace EmployeeWageProblem
{
    class EmployeeWageComputation
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int WORKING_DAYS_PER_MONTH = 20;
        public const int MAXIMUM_WORKING_HOURS = 100;

        static void calculateEmpWages()
        {
            //Variables
            int empHours = 0;
            int empWage = 0;
            int totalHours = 0;
            int days = 0;

            //To get a random number by using Random class
            Random random = new Random();

            //Calculate wages for a month
            while (days != WORKING_DAYS_PER_MONTH && totalHours != MAXIMUM_WORKING_HOURS)
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
            //Calculation of Daily wage
            empWage = totalHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage: " + empWage);
        }
        static void Main(string[] args)
        {
            calculateEmpWages();
        }
    }
}
