using System;

namespace AddrBookUsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System using Linq");

            //Creating object for ContactDataManager 
            ContactDataManager contactDataManager = new ContactDataManager();
            contactDataManager.CreateDataTable();
            contactDataManager.AddValues();
            contactDataManager.Display();

        }
    }
}
