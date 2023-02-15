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

        public void CreateContact()
        {
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
        }
        public void Display()
        {
            Console.WriteLine("\nContact Details :\nFirst Name   :" + contact.LastName + "\nLast Name    :" + contact.LastName + "\nAdress       :" + contact.Address + "\nCity         :" + contact.City + "\nState        :" + contact.State + "\nPhone Number :" + contact.PhoneNumber + "\nZip          :" + contact.Zip + "\nEmail        :" + contact.Email);
        }
    }
}
