using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookSystem
    {
        private Dictionary<string, AddressBook> addressBooks;
        private AddressBook selectedAddressBook;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
            selectedAddressBook = null;
        }

        public void CreateAddressBook(string addressBookName)
        {
            if (!addressBooks.ContainsKey(addressBookName))
            {
                AddressBook addressBook = new AddressBook();
                addressBooks.Add(addressBookName, addressBook);
                Console.WriteLine($"Address book '{addressBookName}' created successfully!");
            }
            else
            {
                Console.WriteLine("Address book with the same name already exists. Please choose a different name.");
            }
        }

        public void SelectAddressBook(string addressBookName)
        {
            if (addressBooks.ContainsKey(addressBookName))
            {
                selectedAddressBook = addressBooks[addressBookName];
                Console.WriteLine($"Address book '{addressBookName}' selected.");
            }
            else
            {
                Console.WriteLine("Address book not found. Please try again.");
            }
        }

        public void AddContact(string firstName, string lastName, string address, string city, string state, string zip, string phoneNumber, string emailAddress)
        {
            if (selectedAddressBook != null)
            {
                ContactPerson contact = new ContactPerson(firstName, lastName, address, city, state, zip, phoneNumber, emailAddress);
                selectedAddressBook.AddContact(contact);
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void EditContact(string firstName, string lastName)
        {
            if (selectedAddressBook != null)
            {
                selectedAddressBook.EditContact(firstName, lastName);
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void DeleteContact(string firstName, string lastName)
        {
            if (selectedAddressBook != null)
            {
                selectedAddressBook.DeleteContact(firstName, lastName);
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void DisplayAllContacts()
        {
            if (selectedAddressBook != null)
            {
                selectedAddressBook.DisplayContacts();
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void SearchPersonByCity(string city)
        {
            List<ContactPerson> searchResults = addressBooks.Values.SelectMany(addressBook => addressBook.SearchByCity(city)).ToList();

            if (searchResults.Count > 0)
            {
                Console.WriteLine($"Search results for city '{city}':");
                foreach (ContactPerson contact in searchResults)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"No contacts found in the city '{city}'.");
            }
        }

        public void SearchPersonByState(string state)
        {
            List<ContactPerson> searchResults = addressBooks.Values.SelectMany(addressBook => addressBook.SearchByState(state)).ToList();

            if (searchResults.Count > 0)
            {
                Console.WriteLine($"Search results for state '{state}':");
                foreach (ContactPerson contact in searchResults)
                {
                    Console.WriteLine(contact);
                }
            }
            else
            {
                Console.WriteLine($"No contacts found in the state '{state}'.");
            }
        }
    }

}
