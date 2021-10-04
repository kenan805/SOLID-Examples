using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    // I - Interface segregation principle

    public interface IBaseWorker //Butun workerlere aid interface
    {
        string ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }

    public interface IFullTimeWorkerSalary : IBaseWorker //Yalniz full time workerlere aid interface
    {
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }
        float CalculateNetSalary();
    }

    public interface IContractWorkerSalary : IBaseWorker //Yalniz contract workerlere aid interface
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalaculateWorkedSalary();
    }

    public class FullTimeEmployeeFixed : IFullTimeWorkerSalary 
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
    }

    public class ContractEmployeeFixed : IContractWorkerSalary
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float HourlyRate { get; set; }
        public float HoursInMonth { get; set; }
        public float CalaculateWorkedSalary() => HourlyRate * HoursInMonth;
    }
}
