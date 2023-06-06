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
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Address Book!");

            Dictionary<string, AddressBook> addressBooks = new Dictionary<string, AddressBook>();

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Create a new address book");
                Console.WriteLine("2. Select an address book");
                Console.WriteLine("3. Add a contact");
                Console.WriteLine("4. View all contacts");
                Console.WriteLine("5. Sort entries by name");
                Console.WriteLine("6. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateAddressBook(addressBooks);
                        break;
                    case "2":
                        SelectAddressBook(addressBooks);
                        break;
                    case "3":
                        AddContact(addressBooks);
                        break;
                    case "4":
                        ViewContacts(addressBooks);
                        break;
                    case "5":
                        SortEntriesByName(addressBooks);
                        break;
                    case "6":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

            Console.WriteLine("Thank you for using the Address Book!");
        }

        static void CreateAddressBook(Dictionary<string, AddressBook> addressBooks)
        {
            Console.WriteLine("Enter the name for the new address book:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address book with the same name already exists.");
            }
            else
            {
                addressBooks[name] = new AddressBook();
                Console.WriteLine($"Address book '{name}' created successfully!");
            }
        }

        static void SelectAddressBook(Dictionary<string, AddressBook> addressBooks)
        {
            Console.WriteLine("Enter the name of the address book to select:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"Address book '{name}' selected.");
            }
            else
            {
                Console.WriteLine("Address book not found. Please create a new address book or select an existing one.");
            }
        }

        static void AddContact(Dictionary<string, AddressBook> addressBooks)
        {
            Console.WriteLine("Enter the address book name to add the contact:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Enter the contact details:");

                Console.WriteLine("First Name:");
                string firstName = Console.ReadLine();

                Console.WriteLine("Last Name:");
                string lastName = Console.ReadLine();

                Console.WriteLine("Address:");
                string address = Console.ReadLine();

                Console.WriteLine("City:");
                string city = Console.ReadLine();

                Console.WriteLine("State:");
                string state = Console.ReadLine();

                Console.WriteLine("Zip Code:");
                string zip = Console.ReadLine();

                Console.WriteLine("Phone Number:");
                string phoneNumber = Console.ReadLine();

                Console.WriteLine("Email Address:");
                string email = Console.ReadLine();

                ContactPerson contact = new ContactPerson
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Address = address,
                    City = city,
                    State = state,
                    Zip = zip,
                    PhoneNumber = phoneNumber,
                    Email = email
                };

                addressBooks[name].AddContact(contact);
                Console.WriteLine("Contact added successfully!");
            }
            else
            {
                Console.WriteLine("Address book not found. Please create a new address book or select an existing one.");
            }
        }

        static void ViewContacts(Dictionary<string, AddressBook> addressBooks)
        {
            Console.WriteLine("Enter the address book name to view contacts:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"Contacts in Address Book '{name}':");
                addressBooks[name].ViewContacts();
            }
            else
            {
                Console.WriteLine("Address book not found. Please create a new address book or select an existing one.");
            }
        }

        static void SortEntriesByName(Dictionary<string, AddressBook> addressBooks)
        {
            Console.WriteLine("Enter the address book name to sort entries:");
            string name = Console.ReadLine();

            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine($"Sorting entries in Address Book '{name}' by name:");
                addressBooks[name].SortEntriesByName();
            }
            else
            {
                Console.WriteLine("Address book not found. Please create a new address book or select an existing one.");
            }
        }
    }

}