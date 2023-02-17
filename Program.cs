namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBookSystem adressbook = new AddressBookSystem();
            bool flage = true;
            while (flage)
            {
                Console.WriteLine("**************** Welcome To Address Book System ****************");
                Console.WriteLine("1.CreateContact\n2.EditContact\n3.Delete Contact\n4.Display");
                int iOption = Convert.ToInt32(Console.ReadLine());

                switch (iOption)
                {

                    case 1:
                        adressbook.CreateContact();
                        break;
                    case 2:
                        adressbook.EditContact();
                        break;
                    case 3:
                        adressbook.DeleteContact();
                        break;
                    case 4:
                        adressbook.Display();
                        break;
                    case 5:
                        Console.WriteLine("Contact Not Found");
                        break;

                }


                Console.ReadLine();
            }
            
        }
    }
}

