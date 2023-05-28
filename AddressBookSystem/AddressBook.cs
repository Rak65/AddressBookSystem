using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        private List<ContactPerson> contacts;

        public AddressBook()
        {
            contacts = new List<ContactPerson>();
        }

        public void AddContact(ContactPerson contact)
        {
            if (!IsDuplicateContact(contact))
            {
                contacts.Add(contact);
                Console.WriteLine("Contact added successfully!");
            }
            else
            {
                Console.WriteLine("Duplicate contact. Contact not added.");
            }
        }

        public void EditContact(string firstName, string lastName)
        {
            ContactPerson contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                Console.WriteLine($"Current details of {firstName} {lastName}:");
                Console.WriteLine(contact);

                Console.WriteLine("Enter the new details:");
                Console.Write("Enter the new first name: ");
                string newFirstName = Console.ReadLine();
                Console.Write("Enter the new last name: ");
                string newLastName = Console.ReadLine();
                Console.Write("Enter the new address: ");
                string newAddress = Console.ReadLine();
                Console.Write("Enter the new city: ");
                string newCity = Console.ReadLine();
                Console.Write("Enter the new state: ");
                string newState = Console.ReadLine();
                Console.Write("Enter the new zip: ");
                string newZip = Console.ReadLine();
                Console.Write("Enter the new phone number: ");
                string newPhoneNumber = Console.ReadLine();
                Console.Write("Enter the new email address: ");
                string newEmailAddress = Console.ReadLine();

                contact.FirstName = newFirstName;
                contact.LastName = newLastName;
                contact.Address = newAddress;
                contact.City = newCity;
                contact.State = newState;
                contact.Zip = newZip;
                contact.PhoneNumber = newPhoneNumber;
                contact.EmailAddress = newEmailAddress;

                Console.WriteLine("Contact updated successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found. Please try again.");
            }
        }

        public void DeleteContact(string firstName, string lastName)
        {
            ContactPerson contact = FindContact(firstName, lastName);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Contact deleted successfully!");
            }
            else
            {
                Console.WriteLine("Contact not found. Please try again.");
            }
        }

        public void DisplayContacts()
        {
            if (contacts.Count > 0)
            {
                Console.WriteLine("Contacts:");
                foreach (ContactPerson contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("No contacts found.");
            }
        }

        public void SearchByCity(string city)
        {
            List<ContactPerson> searchResults = contacts.FindAll(c => c.City.Equals(city, StringComparison.OrdinalIgnoreCase));
            if (searchResults.Count > 0)
            {
                Console.WriteLine($"Search results in {city}:");
                foreach (ContactPerson contact in searchResults)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"No contacts found in {city}.");
            }
        }

        public void SearchByState(string state)
        {
            List<ContactPerson> searchResults = contacts.FindAll(c => c.State.Equals(state, StringComparison.OrdinalIgnoreCase));
            if (searchResults.Count > 0)
            {
                Console.WriteLine($"Search results in {state}:");
                foreach (ContactPerson contact in searchResults)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"No contacts found in {state}.");
            }
        }

        private bool IsDuplicateContact(ContactPerson contact)
        {
            return contacts.Exists(c => c.Equals(contact));
        }

        private ContactPerson FindContact(string firstName, string lastName)
        {
            return contacts.Find(c => c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) && c.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }
    }
}
