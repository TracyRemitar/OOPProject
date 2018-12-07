using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    class Calculations
    {
        public static void CalculateAge()
        {
            string birthDate = "07/26/2000";
            int ageInMonths;
            int age;
            DateTime now = DateTime.UtcNow;
            DateTime past = Convert.ToDateTime(birthDate);

            ageInMonths = 12 * (now.Year - past.Year) + (now.Month - past.Month);
            age = ageInMonths / 12;
            Console.WriteLine(age);
            Console.ReadLine();
        }
        public decimal CalculateInterest(decimal principalAmount, decimal monthlyRate)
        {
            decimal interest = principalAmount * (monthlyRate / 100);
            return interest;
        }
        public decimal CalculateAccruedAmount(decimal principalAmount, decimal monthlyRate, string date, decimal interest)
        {
            date = "07/26/2000";
            DateTime now = DateTime.UtcNow;
            DateTime past = Convert.ToDateTime(date);
            int Months = 12 * (now.Year - past.Year) + (now.Month - past.Month);
            return principalAmount + (interest * Months);
        }
    }
}
