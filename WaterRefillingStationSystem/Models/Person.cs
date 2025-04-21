using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterRefillingStationSystem.Models
{
    public class Person
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string GetFullName 
        {
            get 
            {
                return FullName();
            }
        }

        public Person(string iD, string firstName, string lastName, int age, string address)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Address = address;
        }

        public virtual string FullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
