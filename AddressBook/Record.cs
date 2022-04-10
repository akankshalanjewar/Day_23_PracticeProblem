using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Records
    {

        List<Contacts> records = new List<Contacts>();


        //Displaying all COntact of AddressBook
        public void ToPrint()
        {
            if (records.Count == 0)
            {
                Console.WriteLine("AddressBook is empty, please add some records or Address");
            }
            int reco = 1;
            foreach (var person in records.ToList())
            {
                Console.WriteLine("\n\nRecord - " + reco);
                Console.WriteLine("First Name : " + person.FirstName);
                Console.WriteLine("Last Name : " + person.LastName);
                Console.WriteLine("Address : " + person.Address);
                Console.WriteLine("City : " + person.City);
                Console.WriteLine("State : " + person.State);
                Console.WriteLine("Email : " + person.Email);
                Console.WriteLine("Zip code : " + person.Zip);
                Console.WriteLine("Phone Number : " + person.PhoneNumber);
                reco++;

            }
        }

        //Adding record to address book
        public void AddRecord()
        {
            Contacts contact = new Contacts();


            // adding new contact

            Console.WriteLine("Enter your First Name : ");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name : ");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address : ");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter your City Name : ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State Name : ");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Zip Code : ");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Phone Number : ");
            contact.PhoneNumber = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter your Email Address: ");
            contact.Email = Console.ReadLine();

            records.Add(contact);


        }


        //Serch the person by city name
        public void CheckByCity()
        {
            Console.WriteLine("Please enter the city name to find person: ");
            string ecity = Console.ReadLine();
            List<Contacts> contacts = records.FindAll(x => (x.city == ecity));

            //Checking for Availability
            if (contacts.Count == 0)
            {
                Console.WriteLine("No person found in that City");
            }
            else
            {
                Console.WriteLine("Person details are: ");
                foreach (Contacts contact in contacts)
                {
                    Console.WriteLine("\nFirst name is: " + contact.FirstName);
                    Console.WriteLine("Last name is: " + contact.LastName);
                    Console.WriteLine("City : " + contact.City);
                }
            }


        }


        //Search the person by State name
        public void CheckByState()
        {

            Console.WriteLine("Please enter the State to find person: ");
            string estate = Console.ReadLine();
            List<Contacts> contacts1 = records.FindAll(x => (x.State == estate));

            //Checking for availability
            if (contacts1.Count == 0)
            {
                Console.WriteLine("No person found in that state");
            }
            else
            {
                Console.WriteLine("Person details are: ");
                foreach (Contacts contact in contacts1)
                {
                    Console.WriteLine("\nFirst name is: " + contact.FirstName);
                    Console.WriteLine("Last name is: " + contact.LastName);
                    Console.WriteLine("State : " + contact.State);
                }
            }

        }
    }
}