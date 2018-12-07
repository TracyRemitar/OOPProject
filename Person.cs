using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string BirthDate;
        public string Address;

        public Person(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string GetFullName()
        {

             if (MiddleName.Length == 1)
                return string.Format(FirstName.First().ToString().ToUpper() + FirstName.Substring(1).ToLower() + " " + MiddleName.First().ToString().ToUpper() + ". " + LastName.First().ToString().ToUpper()) + LastName.Substring(1).ToLower() + " ";
            else
                return FirstName.First().ToString().ToUpper() + FirstName.Substring(1).ToLower() + " " + MiddleName.First().ToString().ToUpper() + MiddleName.Substring(1).ToLower() + " " + LastName.First().ToString().ToUpper() + LastName.Substring(1).ToLower() + " ";
        }
        public void GetAge()
        {
            Calculations.CalculateAge();
        }
    }
}
