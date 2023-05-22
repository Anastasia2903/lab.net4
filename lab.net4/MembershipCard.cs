using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab.net4
{
    class MembershipCard : IComponent
    {
        public string MembershipNumber { get; set; }
        public string MembershipLevel { get; set; }
        public string ClubName { get; set; }
        public DateTime JoiningDate { get; set; }

        public void SetData(string membershipNumber, string membershipLevel, string clubName, DateTime joiningDate)
        {
            MembershipNumber = membershipNumber;
            MembershipLevel = membershipLevel;
            ClubName = clubName;
            JoiningDate = joiningDate;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Membership Card Information");
            Console.WriteLine($"Membership Number: {MembershipNumber}");
            Console.WriteLine($"Membership Level: {MembershipLevel}");
            Console.WriteLine($"Club Name: {ClubName}");
            Console.WriteLine($"Joining Date: {JoiningDate.ToShortDateString()}");
        }
       
    }
}
