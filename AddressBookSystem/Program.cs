using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookSystem
    {
        // Dictionary to hold multiple address books
        private Dictionary<string, List<Contact>> addressBooks;

        // Constructor to initialize the dictionary
        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, List<Contact>>();
        }

        // Method to add a contact to an address book
        public void AddContact(string addressBookName, Contact contact)
        {
            // If the address book doesn't exist, create it
            if (!addressBooks.ContainsKey(addressBookName))
            {
                addressBooks[addressBookName] = new List<Contact>();
            }

            // Add the contact to the address book
            addressBooks[addressBookName].Add(contact);
        }

        // Method to display all contacts in an address book
        public void DisplayContacts(string addressBookName)
        {
            // If the address book doesn't exist, display an error message
            if (!addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Address book not found.");
                return;
            }

            Console.WriteLine($"Contacts in {addressBookName}:");
            foreach (Contact contact in addressBooks[addressBookName])
            {
                Console.WriteLine("Name: {0} {1}", contact.getFirstName(), contact.getLastName());
                Console.WriteLine("Address: {0}", contact.getAddress());
                Console.WriteLine("City: {0}", contact.getCity());
                Console.WriteLine("State: {0}", contact.getState());
                Console.WriteLine("Zip: {0}", contact.getZip());
                Console.WriteLine("Phone Number: {0}", contact.getPhoneNumber());
                Console.WriteLine("Email: {0}", contact.getEmail());
                Console.WriteLine();
            }
        }

        // Method to edit a contact's details in an address book
        public bool EditContact(string addressBookName, string firstName, string lastName)
        {
            // If the address book doesn't exist, display an error message
            if (!addressBooks.ContainsKey(addressBookName))
            {
                Console.WriteLine("Address book not found.");
                return false;
            }

            // Find the contact to edit
            Contact contact = FindContact(addressBookName, firstName, lastName);
            if (contact != null)
            {
                // Prompt the user to enter the new contact details
                //And update the details
                Console.WriteLine("Enter new details for the contact:");

                Console.Write("Enter First Name: ");
                string newFirstName = Console.ReadLine();
                contact .setFirstName(newFirstName);

                Console.Write("Enter Last Name: ");
                string newLastName = Console.ReadLine();
                contact .setLastName(newLastName);

                Console.Write("Enter Address: ");
                string newAddress = Console.ReadLine();
                contact .setAddress(newAddress);

                Console.Write("Enter City: ");
                string newCity = Console.ReadLine();
                contact .setCity(newCity);

                Console.Write("Enter State: ");
                string newState = Console.ReadLine();
                contact .setState(newState);

                Console.Write("Enter Zip: ");
                string newZip = Console.ReadLine();
                contact .setZip(newZip);

                Console.Write("Enter Phone Number: ");
                string newPhoneNumber = Console.ReadLine();
                contact .setPhoneNumber(newPhoneNumber);

                Console.Write("Enter Email: ");
                string newEmail = Console.ReadLine();
                contact .setEmail(newEmail);
                Console.WriteLine("Contact updated successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("Contact not found.");
                return false;
            }
        }

        // find a contact in an address book
        private Contact FindContact(string addressBookName, string firstName, string lastName)
        {
            if (addressBooks.ContainsKey(addressBookName))
            {
                List<Contact> contacts = addressBooks[addressBookName];
                return contacts.Find(c => c.getFirstName() == firstName && c.getLastName() == lastName);
            }

            return null;
        }
        public static void Main(string[] args)
        {
            int option;
            do
            {
                AddressBookSystem addressBookSystem = new AddressBookSystem();
                Contact contact = new Contact();
                Console.WriteLine("Choose your option :");
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display all Contact.");
                Console.WriteLine("3.Edit Contact.");
                //Console.WriteLine("4.Delete Contact.");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Address Book Name");
                        string addressBookName= Console.ReadLine();
                        addressBookSystem .AddContact(addressBookName, contact);
                        break;
                    case 2:
                        Console.WriteLine("Enter which AddressBook you want to display");
                        string addressBook= Console.ReadLine();
                        addressBookSystem.DisplayContacts(addressBook);
                        break;
                    case 3:
                        Console.WriteLine("Enter your first name");
                        string firstName= Console.ReadLine();
                        Console.WriteLine("Enter your last name");
                        string lastName= Console.ReadLine();
                        Console.WriteLine("Enter which AddressBook you want to display");
                        string addressBookE = Console.ReadLine();
                        addressBookSystem.EditContact (addressBookE,firstName ,lastName);
                        break;

                    default:
                        Console.WriteLine("Enter valid option :");
                        break;
                }
                Console.WriteLine("Do you want to continue (1.Continue 0.Exit)");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option != 0);

            Console.ReadKey();
        }
    }
    
}