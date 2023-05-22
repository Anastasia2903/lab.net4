using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.net4
{
    class InsurancePolicy : IComponent
    {
        public string PolicyNumber { get; set; }
        public string PolicyType { get; set; }
        public string Insurer { get; set; }
        public decimal CoverageAmount { get; set; }
        public decimal totalCoverage { get; set; }

        public void SetData(string policyNumber, string policyType, string insurer, decimal coverageAmount)
        {
            PolicyNumber = policyNumber;
            PolicyType = policyType;
            Insurer = insurer;
            CoverageAmount = coverageAmount;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Insurance Policy Information");
            Console.WriteLine($"Policy Number: {PolicyNumber}");
            Console.WriteLine($"Policy Type: {PolicyType}");
            Console.WriteLine($"Insurer: {Insurer}");
            Console.WriteLine($"Coverage Amount: {CoverageAmount:C}");
           
        }
       
    }
}
