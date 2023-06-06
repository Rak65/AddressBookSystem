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
            contacts.Add(contact);
        }

        public void ViewContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found in the address book.");
            }
            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact.ToString());
                }
            }
        }

        public void SortEntriesByName()
        {
            contacts.Sort((p1, p2) => string.Compare(p1.FullName, p2.FullName));

            Console.WriteLine("Sorted entries by name:");

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }
        public void SortEntriesByCity()
        {
            contacts.Sort((p1, p2) => string.Compare(p1.City, p2.City));

            Console.WriteLine("Sorted entries by city:");

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }
        public void SortEntriesByState()
        {
            contacts.Sort((p1, p2) => string.Compare(p1.State, p2.State));

            Console.WriteLine("Sorted entries by state:");

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }

        public void SortEntriesByZip()
        {
            contacts.Sort((p1, p2) => string.Compare(p1.Zip, p2.Zip));

            Console.WriteLine("Sorted entries by zip code:");

            foreach (var contact in contacts)
            {
                Console.WriteLine(contact.ToString());
            }
        }
    }
}
