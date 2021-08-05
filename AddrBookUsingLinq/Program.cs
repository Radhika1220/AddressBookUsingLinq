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
            //contactDataManager.CreateDataTable();
            //contactDataManager.AddValues();
            //contactDataManager.DisplayDetails();

            //contactDataManager.ModifyDataTableUsingName("Priya","LastName");
            //contactDataManager.DeleteRecordUsingName("Vishnu");
            //contactDataManager.RetrieveDataBasedOnCityorState("Chennai", "TamilNadu");
            contactDataManager.RetrieveCountBasedOnCityorState();
        }
    }
}
