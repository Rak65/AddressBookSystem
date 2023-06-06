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
    }
}
