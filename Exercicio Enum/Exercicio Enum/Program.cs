﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_Enum;
using Exercicio_Enum.Entities;
using Exercicio_Enum.Entities.Enums;

namespace Exercicio_Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name:");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());

            Console.Write("Base salary:");
            double baseSalary = double.Parse(Console.ReadLine());

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);

            }

            Console.Write("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int mount = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine(("Name: " + worker.Name));
            Console.WriteLine(("Department: " + worker.Department.Name));
            Console.WriteLine(("Income for: " + monthAndYear + ": " +worker.Income(year,mount).ToString("F2")));



            Console.ReadLine();
           
        }
    }
}