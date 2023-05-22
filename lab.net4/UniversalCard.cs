using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.net4
{
    class UniversalCard : IComponent
    {
        private List<IComponent> components = new List<IComponent>();

        public BankCard BankCard { get; set; }

       
        public void SetBankCardData(string cardNumber, string cardHolderName, string bankName, DateTime expiryDate)
        {
            BankCard.SetData(cardNumber, cardHolderName, bankName, expiryDate);
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }

        public void RemoveComponent(IComponent component)
        {
            components.Remove(component);
        }

        public IComponent GetComponent<T>() where T : IComponent
        {
            return components.Find(c => c is T);
        }
       

        public void DisplayInfo()
        {
            Console.WriteLine("Universal Card Information");
            Console.WriteLine();

            
            decimal totalCoverage = CalculateTotalCoverage();
            //Console.WriteLine($"Total Coverage: {totalCoverage:C}");


            foreach (var component in components)
            {
                component.DisplayInfo();
                Console.WriteLine(); // Добавляем пустую строку после вывода информации о каждом компоненте
            }
        }
        public decimal CalculateTotalCoverage()
        {
            decimal totalCoverage = 0;

            foreach (var component in components)
            {
                if (component is InsurancePolicy insurancePolicy)
                {
                    totalCoverage += insurancePolicy.CoverageAmount;
                }
            }

            return totalCoverage;
        }
       
    }
}
