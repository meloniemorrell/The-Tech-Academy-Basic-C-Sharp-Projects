using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_245
{
    class Employee
    {
        private int Id;
        private string FirstName;
        private string LastName;

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFirstName
        {
            get
            {
                return FirstName;
            }
            set
            {
                FirstName = value;
            }
        }

        public int GetId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
    }

}
