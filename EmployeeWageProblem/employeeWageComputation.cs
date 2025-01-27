﻿using System;

namespace EmployeeWageProblem
{
    public class EmployeeWageComputation
    {
        //Constants
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private String company;
        private int empRatePerHour;
        private int workingDaysPerMonth;
        private int maximumWorkingHours;

        public EmployeeWageComputation(String company, int empRatePerHour, int workingDaysPerMonth, int maximumWorkingHours)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.workingDaysPerMonth = workingDaysPerMonth;
            this.maximumWorkingHours = maximumWorkingHours;
        }

        //Calculate total employee wage for a company 
        void calculateEmpWages()
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
            EmployeeWageComputation infosys = new EmployeeWageComputation("Infosys", 20, 22, 100);
            EmployeeWageComputation reliance = new EmployeeWageComputation("Reliance", 30, 20, 90);
            infosys.calculateEmpWages();
            reliance.calculateEmpWages();
        }
    }
}
