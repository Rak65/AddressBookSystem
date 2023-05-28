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
        static void Main(string[] args)
        {
            AddressBookSystem addressBookSystem = new AddressBookSystem();

            while (true)
            {
                Console.WriteLine("1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Add Contact");
                Console.WriteLine("4. Edit Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Display Contacts");
                Console.WriteLine("7. Search Person in City");
                Console.WriteLine("8. Search Person in State");
                Console.WriteLine("9. View Persons by City");
                Console.WriteLine("10. View Persons by State");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter the name of the address book: ");
                        string addressBookName = Console.ReadLine();
                        addressBookSystem.CreateAddressBook(addressBookName);
                        break;
                    case "2":
                        Console.Write("Enter the name of the address book: ");
                        addressBookName = Console.ReadLine();
                        addressBookSystem.SelectAddressBook(addressBookName);
                        break;
                    case "3":
                        Console.Write("Enter the first name: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Enter the last name: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Enter the address: ");
                        string address = Console.ReadLine();
                        Console.Write("Enter the city: ");
                        string city = Console.ReadLine();
                        Console.Write("Enter the state: ");
                        string state = Console.ReadLine();
                        Console.Write("Enter the zip: ");
                        string zip = Console.ReadLine();
                        Console.Write("Enter the phone number: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Enter the email address: ");
                        string emailAddress = Console.ReadLine();

                        addressBookSystem.AddContact(firstName, lastName, address, city, state, zip, phoneNumber, emailAddress);
                        break;
                    case "4":
                        Console.Write("Enter the first name of the contact to edit: ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter the last name of the contact to edit: ");
                        lastName = Console.ReadLine();

                        addressBookSystem.EditContact(firstName, lastName);
                        break;
                    case "5":
                        Console.Write("Enter the first name of the contact to delete: ");
                        firstName = Console.ReadLine();
                        Console.Write("Enter the last name of the contact to delete: ");
                        lastName = Console.ReadLine();

                        addressBookSystem.DeleteContact(firstName, lastName);
                        break;
                    case "6":
                        addressBookSystem.DisplayAllContacts();
                        break;
                    case "7":
                        Console.Write("Enter the city to search for: ");
                        string searchCity = Console.ReadLine();
                        addressBookSystem.SearchPersonByCity(searchCity);
                        break;
                    case "8":
                        Console.Write("Enter the state to search for: ");
                        string searchState = Console.ReadLine();
                        addressBookSystem.SearchPersonByState(searchState);
                        break;
                    case "9":
                        Console.Write("Enter the city to view persons: ");
                        string viewCity = Console.ReadLine();
                        addressBookSystem.ViewPersonsByCity(viewCity);
                        break;
                    case "10":
                        Console.Write("Enter the state to view persons: ");
                        string viewState = Console.ReadLine();
                        addressBookSystem.ViewPersonsByState(viewState);
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                addressBookSystem.GetCountByCity();
                Console.WriteLine();

                addressBookSystem.GetCountByState();

                Console.WriteLine();
            }
        }
    }

}