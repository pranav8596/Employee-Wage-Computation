using System;

namespace EmployeeWageProblem
{
     
    class EmployeeWageComputation
    {
        //Constants
        static int IS_FULL_TIME = 1;
        static int EMP_RATE_PER_HOUR = 20;
        
        static void Main(string[] args)
        {
            //Variables
            int empHours = 0;
            int empWage = 0;

            //To get a random number by using Random class
            Random random = new Random();
            double empCheck =  Math.Floor(random.NextDouble() * 10) % 2;

            //Check if an Employee is Present or Absent 
            if (empCheck == IS_FULL_TIME)
            {
                empHours = 8;
                Console.WriteLine("Employee is Present");
            }
            else
            {
                empHours = 0;
                Console.WriteLine("Employee is Absent");
            }

            //Calculation of Daily wage
            empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage: " + empWage);

        }
    }
}
