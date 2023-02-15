namespace AddressBookSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************** Welcome To Address Book System ****************");
            AddressBookSystem adressbook = new AddressBookSystem();
            adressbook.CreateContact();
            adressbook.Display();
            Console.ReadLine();
        }
    }
}