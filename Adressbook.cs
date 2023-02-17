using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookSystem
    {
        Contact contact = new Contact();
        List<Contact> contactList = new List<Contact>();
        public void CreateContact()
        {
            contact = new Contact();
            Console.Write("Please Enter First Name :");
            contact.FirstName = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Last Name :");
            contact.LastName = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your Address :");
            contact.Address = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your City :");
            contact.City = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your State :");
            contact.State = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your Phone Number :");
            contact.PhoneNumber = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your Pin Code :");
            contact.Zip = Convert.ToString(Console.ReadLine());
            Console.Write("Please Enter Your Email Id :");
            contact.Email = Convert.ToString(Console.ReadLine());
            contactList.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("\nContact Details :\nFirst Name   :" + contact.LastName + "\nLast Name    :" + contact.LastName + "\nAdress       :" + contact.Address + "\nCity         :" + contact.City + "\nState        :" + contact.State + "\nPhone Number :" + contact.PhoneNumber + "\nZip          :" + contact.Zip + "\nEmail        :" + contact.Email);
        }
        public void EditContact()
        {
            bool flag = true;
            Console.WriteLine("Enter Name To Edit the Contaict Details");
            string sName = Console.ReadLine();

            foreach (Contact iContact in contactList)
            {
                if (iContact.FirstName == sName)
                {
                    while (flag)
                    {
                        Console.WriteLine("\n1:Edit first name\n2:Edit last name\n3:Edit address\n4:Edit city\n5:Edit state\n6:Edit phone number\n7:Edit zip code\n8:Edit email id\n");
                        int iOption = Convert.ToInt32(Console.ReadLine());
                        switch (iOption)
                        {
                            case 1:
                                Console.WriteLine("Enter First name");
                                string NewName = Console.ReadLine();
                                iContact.FirstName = NewName;
                                flag = false;
                                break;
                            case 2:
                                Console.WriteLine("Enter Last name");
                                string NewLastName = Console.ReadLine();
                                iContact.FirstName = NewLastName;
                                flag = false;
                                break;
                            case 3:
                                Console.WriteLine("Enter address");
                                string NewAddress = Console.ReadLine();
                                iContact.Address = NewAddress;
                                flag = false;
                                break;
                            case 4:
                                Console.WriteLine("Enter city");
                                string NewCity = Console.ReadLine();
                                iContact.City = NewCity;
                                flag = false;
                                break;
                            case 5:
                                Console.WriteLine("Enter state");
                                string NewState = Console.ReadLine();
                                iContact.State = NewState;
                                flag = false;
                                break;
                            case 6:
                                Console.WriteLine("Enter phone number");
                                string NewPhoneNumber = Console.ReadLine();
                                iContact.PhoneNumber = NewPhoneNumber;
                                flag = false;
                                break;
                            case 7:
                                Console.WriteLine("Enter zip ocde");
                                string NewZip = Console.ReadLine();
                                iContact.Zip = NewZip;
                                flag = false;
                                break;
                            case 8:
                                Console.WriteLine("Enter Email id");
                                string NewEmail = Console.ReadLine();
                                iContact.Email = NewEmail;
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("Enter the Option");
                                break;
                        }
                    }



                }
                else
                {
                    Console.WriteLine("Contact Not Found");
                    break;
                }
            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter The Firdst Name");
            string sName = Console.ReadLine();
            Contact deleteContact = new Contact();
            foreach (Contact Con in contactList)
            {
                if(Con.FirstName == sName)
                {
                    contactList.Remove(Con);
                    Console.WriteLine("Contact Delete Successfully");

                }
            }
        }
    }
}
