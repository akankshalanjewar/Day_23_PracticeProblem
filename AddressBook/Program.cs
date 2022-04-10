using System;

namespace AddressBook
{
       class Contacts
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string email { get; set; }
            public int zip { get; set; }
            public long phoneNumber { get; set; }

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Welcome to AddressBook problem");

                Records records = new Records();



                //Infinite Loop
                while (true)
                {
                    Console.WriteLine("\nEnter 1 to Add person in AddressBook");
                    Console.WriteLine("Enter 2 to Display");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            records.AddRecord();
                            break;
                        case 2:
                            records.ToPrint();
                            break;
                        default:
                            Console.WriteLine("Pleasee select valid input");
                            break;

                    }

                }
            }
        }
    
}


    

