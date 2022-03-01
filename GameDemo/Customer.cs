using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo
{
    public class Customer
    {
        public string NationalId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DateOfBirth { get; set; }
        public float Balance { get; set; }

        public Customer(string nationalId, string name, string surname, int dateOfBirth)
        {
            NationalId = nationalId;
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Balance = 0;
        }

    }
}
