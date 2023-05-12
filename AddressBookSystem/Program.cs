﻿using System;
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
    class AddressBookSystem
    {
        public static void Main(string[] args)
        {
            List<Contact> lis = new List<Contact>();
            int option;
            do
            {
                Contact contact = new Contact();
                Console.WriteLine("Choose your option :");
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display all Contact.");
                Console.WriteLine("3.Edit Contact.");
                Console.WriteLine("4.Delete Contact.");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        contact.Add_Contact(lis);
                        break;
                    case 2:
                        contact.DisplayContacts(lis);
                        break;
                    case 3:
                        Console.WriteLine("Enter your first name");
                        string firstName= Console.ReadLine();
                        Console.WriteLine("Enter your last name");
                        string lastName= Console.ReadLine();
                        contact .EditContact (lis,firstName ,lastName);
                        break;
                    case 4:
                        Console.WriteLine("Enter your first name");
                        string firstN = Console.ReadLine();
                        Console.WriteLine("Enter your last name");
                        string lastN = Console.ReadLine();
                        contact.DeleteContact (lis,firstN,lastN);
                        break;
                    default:
                        Console.WriteLine("Enter valid option :");
                        break;
                }
                Console.WriteLine("Do you want to continue (1.Continue 0.Exit)");
                option = Convert.ToInt32(Console.ReadLine());
            } while (option != 0);

            Console.ReadKey();
        }
    }
    
}