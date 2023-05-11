using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        private String firstName;
        private String lastName;
        private String city;
        private String state;
        private String zip;
        private String phoneNumber;
        private String email;

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }
        public String getFirstName()
        {
            return firstName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }
        public String getLastName()
        {
            return lastName;
        }

        public void setCity(String city)
        {
            this.city = city;
        }
        public String getCity()
        {
            return city;
        }

        public void setState(String state)
        {
            this.state = state;
        }
        public String getState()
        {
            return state;
        }

        public void setZip(String zip)
        {
            this.zip = zip;
        }
        public String getZip()
        {
            return zip;
        }

        public void setPhoneNumber(String phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }
        public String getPhoneNumber()
        {
            return phoneNumber;
        }

        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return email;
        }
        public void Add_Contact(List<Contact> lis)
        { 
            Contact P1 = new Contact();
            Console.WriteLine("Enter First Name: ");
            P1.setFirstName(Console.ReadLine());
            Console.WriteLine("Enter Last Name : ");
            P1.setLastName(Console.ReadLine());
            Console.WriteLine("Enter City : ");
            P1.setCity(Console.ReadLine());
            Console.WriteLine("Enter State : ");
            P1.setState(Console.ReadLine());
            Console.WriteLine("Enter zip : ");
            P1.setZip(Console.ReadLine());
            Console.WriteLine("Enter PhoneNumber: ");
            P1.setPhoneNumber(Console.ReadLine());
            Console.WriteLine("Enter Email ID : ");
            P1.setEmail(Console.ReadLine());
            lis.Add(P1);
        }
        public void DisplayContacts(List<Contact> lis) {

            Console.WriteLine("Contacts in Address Book:");
            foreach (Contact contact in lis)
            {
                Console.WriteLine("Name: {0} {1}", contact.firstName, contact.lastName);
                Console.WriteLine("City: {0}", contact.city);
                Console.WriteLine("State: {0}", contact.state);
                Console.WriteLine("Zip: {0}", contact.zip);
                Console.WriteLine("Phone Number: {0}", contact.phoneNumber);
                Console.WriteLine("Email: {0}", contact.email);
                Console.WriteLine();
            }
        }       

    }
}
