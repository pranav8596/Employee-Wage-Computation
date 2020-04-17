﻿using System;

namespace EmployeeWageProblem
{
    class EmployeeWageComputation
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            //Variables
            int empHours = 0;
            int empWage = 0;

            //To get a random number by using Random class
            Random random = new Random();
            double empCheck = Math.Floor(random.NextDouble() * 10) % 3;

            //Check if an Employee is Present or Absent 
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
            //Calculation of Daily wage
            empWage = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage: " + empWage);

        }
    }
}
