using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContactInfo addressBook = new ContactInfo();
            addressBook.CreateContact();
            Console.ReadKey();
        }
    }
}
