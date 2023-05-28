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
                AddressBook newAddressBook = new AddressBook();
                addressBooks.Add(addressBookName, newAddressBook);
                Console.WriteLine("Address book created successfully!");
            }
            else
            {
                Console.WriteLine("Address book with the same name already exists. Please try again with a different name.");
            }
        }

        public void SelectAddressBook(string addressBookName)
        {
            if (addressBooks.ContainsKey(addressBookName))
            {
                selectedAddressBook = addressBooks[addressBookName];
                Console.WriteLine($"Selected address book: {addressBookName}");
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
    }
}
