using System;

namespace lab.net4
{
    class Program
    {
        static void Main(string[] args)
        {
            
                // Створюємо універсальну картку
                UniversalCard card = new UniversalCard();

                // Створюємо компоненти для універсальної картки
                Passport cardPassport = new Passport();
                InsurancePolicy cardInsurancePolicy = new InsurancePolicy();
                BankCard cardBankCard = new BankCard();
                MembershipCard cardMembershipCard = new MembershipCard();

                // Додаємо компоненти до універсальної картки
                card.AddComponent(cardPassport);
                card.AddComponent(cardInsurancePolicy);
                card.AddComponent(cardBankCard);
                card.AddComponent(cardMembershipCard);

                // Створюємо клієнтів
                UniversalCard client1 = CreateClient1();
                UniversalCard client2 = CreateClient2();
                UniversalCard client3 = CreateClient3();
                UniversalCard client4 = CreateClient4();

                // Виводимо інформацію про всіх клієнтів
                Console.WriteLine("Client 1:");
                client1.DisplayInfo();
                Console.WriteLine();

                Console.WriteLine("Client 2:");
                client2.DisplayInfo();
                Console.WriteLine();

                Console.WriteLine("Client 3:");
                client3.DisplayInfo();
                Console.WriteLine();

                Console.WriteLine("Client 4:");
                client4.DisplayInfo();
                Console.WriteLine();

                Console.ReadLine();

                // Виводимо інформацію про універсальну картку
                card.DisplayInfo();

                decimal totalCoverage = card.CalculateTotalCoverage();
                Console.WriteLine($"Total Coverage Amount: {totalCoverage:C}");

                Console.ReadLine();
        }

         static UniversalCard CreateClient1()
         {
                UniversalCard client = new UniversalCard();

                Passport passport = new Passport();
                InsurancePolicy insurancePolicy = new InsurancePolicy();
                BankCard bankCard = new BankCard();
                MembershipCard membershipCard = new MembershipCard();

                client.AddComponent(passport);
                client.AddComponent(insurancePolicy);
                client.AddComponent(bankCard);
                client.AddComponent(membershipCard);

                passport.SetData("John", "Doe", new DateTime(1990, 1, 1), "AB123456");
                insurancePolicy.SetData("123456789", "Health Insurance", "Insurance Company A", 1000500);
                bankCard.SetData("1111-2222-3333-4444", "John Doe", "Bank A", new DateTime(2025, 12, 31));
                membershipCard.SetData("987654321", "Gold", "Club A", new DateTime(2020, 5, 1));
               
              
                return client;

            
         }
        static UniversalCard CreateClient2()
        {
            UniversalCard client2 = new UniversalCard();

            Passport passport = new Passport();
            InsurancePolicy insurancePolicy = new InsurancePolicy();
            BankCard bankCard = new BankCard();
            MembershipCard membershipCard = new MembershipCard();
            // Додаємо компоненти до картки другого клієнта

            client2.AddComponent(passport);
            client2.AddComponent(insurancePolicy);
            client2.AddComponent(bankCard);   
            client2.AddComponent(membershipCard);

            // Встановлюємо дані для компонентів другого клієнта
            passport.SetData("John", "Will", new DateTime(1975, 5, 1), "UA4785");
            insurancePolicy.SetData("465236549", "Health Insurance", "Insurance Company A", 500000);
            bankCard.SetData("1255-5641-5541-4795", "John Will", "Abank", new DateTime(2025, 10, 31));
            membershipCard.SetData("987654321", "Gold", "Club A", new DateTime(2021, 7, 9));
          
            return client2;


        }
        static UniversalCard CreateClient3()
        {
            UniversalCard client3 = new UniversalCard();

            Passport passport = new Passport();
            InsurancePolicy insurancePolicy = new InsurancePolicy();
            BankCard bankCard = new BankCard();
            MembershipCard membershipCard = new MembershipCard();
            // Додаємо компоненти до картки другого клієнта

            // Додаємо компоненти до картки третього клієнта
            client3.AddComponent(passport);
            client3.AddComponent(insurancePolicy);
            client3.AddComponent(bankCard);
            client3.AddComponent(membershipCard);

            // Встановлюємо дані для компонентів третього клієнта
            passport.SetData("Ketrin", "Piers", new DateTime(2000, 05, 15), "UA1457");
            insurancePolicy.SetData("634781457", "Car Insurance", "Insurance Company B", 1000000);
            bankCard.SetData("4258-7479-1354-4444", "Ketrin Piers", "Pumb_bank", new DateTime(2027, 12, 5));
            membershipCard.SetData("856275697", "Platinum", "Club C", new DateTime(2020, 4, 1));
            



            return client3;



        }
        static UniversalCard CreateClient4()
        {
            UniversalCard client4 = new UniversalCard();

            Passport passport = new Passport();
            InsurancePolicy insurancePolicy = new InsurancePolicy();
            BankCard bankCard = new BankCard();
            MembershipCard membershipCard = new MembershipCard();
            // Додаємо компоненти до картки другого клієнта

           
            // Додаємо компоненти до картки четвертого клієнта
            client4.AddComponent(passport);
            client4.AddComponent(insurancePolicy);
            client4.AddComponent(bankCard);
            client4.AddComponent(membershipCard);

            // Встановлюємо дані для компонентів четвертого клієнта
            passport.SetData("Emma", "Smith", new DateTime(1985, 8, 10), "UK789456");
            insurancePolicy.SetData("789456123", "Life Insurance", "Insurance Company C", 2000000);
            bankCard.SetData("9632-7412-8521-9632", "Emma Smith", "Bank C", new DateTime(2023, 6, 30));
            membershipCard.SetData("123456789", "Silver", "Club B", new DateTime(2019, 9, 1));

           


            return client4;



        }
        // Аналогічно для інших клієнтів (client2, client3, client4)
        // Створіть окремі методи для створення кожного клієнта і налаштування їх компонентів.


    }
}
