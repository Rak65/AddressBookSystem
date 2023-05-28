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
                Console.WriteLine("Duplicate entry. Contact already exists in the address book.");
            }
        }

        public void EditContact(string firstName, string lastName)
        {
            ContactPerson contact = FindContact(firstName, lastName);
            if (contact != null)
            {
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
                Console.WriteLine("Contacts in the address book:");
                foreach (ContactPerson contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine("No contacts found in the address book.");
            }
        }

        private bool IsDuplicateContact(ContactPerson contact)
        {
            return contacts.Any(existingContact =>
                existingContact.FirstName.Equals(contact.FirstName, StringComparison.OrdinalIgnoreCase) &&
                existingContact.LastName.Equals(contact.LastName, StringComparison.OrdinalIgnoreCase));
        }

        private ContactPerson FindContact(string firstName, string lastName)
        {
            return contacts.Find(contact =>
                contact.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contact.LastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));
        }

        public List<ContactPerson> SearchByCity(string city)
        {
            return contacts.FindAll(contact => contact.City.Equals(city, StringComparison.OrdinalIgnoreCase));
        }

        public List<ContactPerson> SearchByState(string state)
        {
            return contacts.FindAll(contact => contact.State.Equals(state, StringComparison.OrdinalIgnoreCase));
        }
    }
}
