using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios_1___Enum__.Entities.Enum;
using Exercicios_1___Enum__.Entities;

namespace Exercicios_1___Enum__.Entities
{
    internal class Worker
    {
        public string Name { get; set; }

        public WorkerLevel level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department { get; set; }
        
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker (string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            BaseSalary = baseSalary;
            Department = department; 
        }

        public Worker()
        {

        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year,int month)
        {
            double sum = BaseSalary; //* Ele vai ganhar esse valor de qualquer jeito se nao seria zero *//
            foreach (HourContract contract in Contracts) //* Percorer a lista de contratos *//
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
