using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.net4
{
    class BankCard : IComponent
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string BankName { get; set; }
        public DateTime ExpiryDate { get; set; }
        
        public decimal salary { get; set; }
        public decimal taxes { get; set; }
        

        public void SetData(string cardNumber, string cardHolderName, string bankName, DateTime expiryDate)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            BankName = bankName;
            ExpiryDate = expiryDate;
            

        }
     

        public void DisplayInfo()
        {
            Console.WriteLine("Bank Card Information");
            Console.WriteLine($"Card Number: {CardNumber}");
            Console.WriteLine($"Card Holder Name: {CardHolderName}");
            Console.WriteLine($"Bank Name: {BankName}");
            Console.WriteLine($"Expiry Date: {ExpiryDate.ToShortDateString()}");
            

            
        }
        
    }
}
