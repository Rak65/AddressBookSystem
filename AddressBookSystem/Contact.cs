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
        // Method to add a contact in address book
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
        }/*
        // Method to find a contact in address book
        private Contact FindContact(List<Contact> lis, string firstName, string lastName)
        {
            return lis.Find(contact =>
                contact.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contact.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
        // Method to edit a contact in address book
        public bool EditContact(List<Contact> lis, string firstName, string lastName)
        {
            Contact contact = FindContact(lis, firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine("Enter new details for the contact:");

                Console.Write("Enter First Name: ");
                string newFirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string newLastName = Console.ReadLine();

                Console.Write("Enter Address: ");
                string newAddress = Console.ReadLine();

                Console.Write("Enter City: ");
                string newCity = Console.ReadLine();

                Console.Write("Enter State: ");
                string newState = Console.ReadLine();

                Console.Write("Enter Zip: ");
                string newZip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                string newPhoneNumber = Console.ReadLine();

                Console.Write("Enter Email: ");
                string newEmail = Console.ReadLine();

                contact.firstName = newFirstName;
                contact.lastName = newLastName;
                contact.city = newCity;
                contact.state = newState;
                contact.zip = newZip;
                contact.phoneNumber = newPhoneNumber;
                contact.email = newEmail;

                Console.WriteLine("Contact updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return false;
            }
        }
        // Method to delete the contact from Address Book
        public bool DeleteContact(List<Contact> lis, string firstName, string lastName)
        {
            Contact contact = FindContact(lis,firstName, lastName);
            if (contact != null)
            {
                lis.Remove(contact);
                Console.WriteLine("Contact deleted successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return false;
            }
        }
        */
        // Method to display the list 
        public void DisplayContacts(List<Contact> lis)
        {

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