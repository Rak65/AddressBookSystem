using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class ContactInfo
    {
        public void CreateContact()
        {
            Console.WriteLine("Enter the first name :");
            string firstName=Console.ReadLine();
            Console.WriteLine("Enter the last name :");
            string lastName=Console.ReadLine();
            Console.WriteLine("Enter the Address: ");
            string address=Console.ReadLine();
            Console.WriteLine("Enter city name :");
            string city =Console.ReadLine();
            Console.WriteLine("Enter state name :");
            string state =Console.ReadLine();
            Console.WriteLine("Enter zip :");
            string zip=Console.ReadLine();
            Console.WriteLine("Enter Phone number :");
            string phoneNo=Console.ReadLine();
            Console.WriteLine("Enter email-id : ");
            string email=Console.ReadLine();
            Console.WriteLine(firstName + " contact is sussessfully done.");
            Console.WriteLine("Enter any key to display the new contact");
            Console .ReadKey();
            Console.WriteLine();

            Console.WriteLine("firstName : " + firstName);
            Console.WriteLine("lastName : " + lastName);
            Console.WriteLine("Address : " + address);
            Console.WriteLine("City : " + city);
            Console.WriteLine("State : " + state);
            Console.WriteLine("Zip code :" + zip);
            Console.WriteLine("Phone number : " + phoneNo);
            Console.WriteLine("Email : " + email);
        }
    }
}
