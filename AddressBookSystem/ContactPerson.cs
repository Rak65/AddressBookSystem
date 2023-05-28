using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public ContactPerson(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
        }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Address: {Address}, City: {City}, State: {State}, Zip: {Zip}, Phone: {PhoneNumber}, Email: {EmailAddress}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            ContactPerson other = (ContactPerson)obj;
            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase) && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (FirstName?.ToLower().GetHashCode() ?? 0);
            hash = hash * 23 + (LastName?.ToLower().GetHashCode() ?? 0);
            return hash;
        }
    }
}