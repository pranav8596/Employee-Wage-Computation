using System;

namespace EmployeeWageProblem
{
    class EmployeeWageComputation
    {
        static void Main(string[] args)
        {
            //Constant
            int IS_FULL_TIME = 1;

            //To get a random number by using Random class
            Random random = new Random();
            double empCheck =  Math.Floor(random.NextDouble() * 10) % 2;

            //Check if an Employee is Present or Absent 
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
