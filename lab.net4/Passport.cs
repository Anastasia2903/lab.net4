using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.net4
{
    class Passport : IComponent
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PassportNumber { get; set; }

        public void SetData(string firstName, string lastName, DateTime dateOfBirth, string passportNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            PassportNumber = passportNumber;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Passport Information");
            Console.WriteLine($"Name: {FirstName} {LastName}");
            Console.WriteLine($"Date of Birth: {DateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Passport Number: {PassportNumber}");
        }
        
    }
}
