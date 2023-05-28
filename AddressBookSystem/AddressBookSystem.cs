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
        private Dictionary<string, List<ContactPerson>> cityPersonDictionary;
        private Dictionary<string, List<ContactPerson>> statePersonDictionary;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook>();
            cityPersonDictionary = new Dictionary<string, List<ContactPerson>>();
            statePersonDictionary = new Dictionary<string, List<ContactPerson>>();
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

                // Add the person to city-person dictionary
                if (!cityPersonDictionary.ContainsKey(city))
                {
                    cityPersonDictionary.Add(city, new List<ContactPerson>());
                }
                cityPersonDictionary[city].Add(contact);

                // Add the person to state-person dictionary
                if (!statePersonDictionary.ContainsKey(state))
                {
                    statePersonDictionary.Add(state, new List<ContactPerson>());
                }
                statePersonDictionary[state].Add(contact);
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
            if (selectedAddressBook != null)
            {
                selectedAddressBook.SearchByCity(city);
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void SearchPersonByState(string state)
        {
            if (selectedAddressBook != null)
            {
                selectedAddressBook.SearchByState(state);
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void ViewPersonsByCity(string city)
        {
            if (cityPersonDictionary.ContainsKey(city))
            {
                List<ContactPerson> persons = cityPersonDictionary[city];
                Console.WriteLine($"Persons in the city of {city}:");
                foreach (ContactPerson person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine($"No persons found in the city of {city}.");
            }
        }

        public void ViewPersonsByState(string state)
        {
            if (statePersonDictionary.ContainsKey(state))
            {
                List<ContactPerson> persons = statePersonDictionary[state];
                Console.WriteLine($"Persons in the state of {state}:");
                foreach (ContactPerson person in persons)
                {
                    Console.WriteLine(person);
                }
            }
            else
            {
                Console.WriteLine($"No persons found in the state of {state}.");
            }
        }
        public void GetCountByCity()
        {
            if (selectedAddressBook != null)
            {
                var countByCity = selectedAddressBook.GetCountByCity();

                if (countByCity.Count > 0)
                {
                    Console.WriteLine("Number of contact persons by city:");
                    foreach (var kvp in countByCity)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("No contact persons found in any city.");
                }
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }

        public void GetCountByState()
        {
            if (selectedAddressBook != null)
            {
                var countByState = selectedAddressBook.GetCountByState();

                if (countByState.Count > 0)
                {
                    Console.WriteLine("Number of contact persons by state:");
                    foreach (var kvp in countByState)
                    {
                        Console.WriteLine($"{kvp.Key}: {kvp.Value}");
                    }
                }
                else
                {
                    Console.WriteLine("No contact persons found in any state.");
                }
            }
            else
            {
                Console.WriteLine("No address book selected. Please select an address book first.");
            }
        }
    }
}
