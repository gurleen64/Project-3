using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hi_Tech_Management_System.BLL
{
    class Person
    {
        private string firstName;
        private string lastName;
        private string PhoneNumber;
        private string faxNumber;
        private string email;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        public string Email { get => email; set => email = value; }
        public Person()
        {
            firstName = "";
            lastName = "";
            PhoneNumber = "";
            faxNumber = "";
            email = "";
        }
        public Person(string firstName, string lastName, string phoneNumber, string faxNumber, string email)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.PhoneNumber = PhoneNumber1;
            this.faxNumber = FaxNumber;
            this.email = Email;
        }
    }
}

