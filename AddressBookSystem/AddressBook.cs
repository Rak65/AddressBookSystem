using System;
using System.Collections.Generic;
using System.IO;
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
        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var contact in contacts)
                {
                    writer.WriteLine($"{contact.FirstName},{contact.LastName},{contact.Address},{contact.City},{contact.State},{contact.Zip},{contact.PhoneNumber},{contact.Email}");
                }
            }

            Console.WriteLine($"Address book saved to '{fileName}' successfully!");
        }

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                contacts.Clear();

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] contactData = line.Split(',');

                        ContactPerson contact = new ContactPerson
                        {
                            FirstName = contactData[0],
                            LastName = contactData[1],
                            Address = contactData[2],
                            City = contactData[3],
                            State = contactData[4],
                            Zip = contactData[5],
                            PhoneNumber = contactData[6],
                            Email = contactData[7]
                        };

                        contacts.Add(contact);
                    }
                }

                Console.WriteLine($"Address book loaded from '{fileName}' successfully!");
            }
            else
            {
                Console.WriteLine($"File '{fileName}' does not exist.");
            }
        }
    }
}
