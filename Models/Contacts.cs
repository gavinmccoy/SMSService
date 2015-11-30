using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMSService.Models
{

    // class used for list of contacts in place of database and for searching through contacts
    public class Contacts
    {
        public List<Contact> contacts = new List<Contact>()
        {
                new Contact { ContactId = 1, FirstName = "Gavin", SecondName = "McCoy", AreaCode = "086", PhoneNumber = "1234567" },
                new Contact { ContactId = 2, FirstName = "Gregory", SecondName = "Peck", AreaCode = "085", PhoneNumber = "8666969" },
                new Contact { ContactId = 3, FirstName = "Harvey", SecondName = "Keitel", AreaCode = "088", PhoneNumber = "9834567" },
                new Contact { ContactId = 4, FirstName = "Jimmy", SecondName = "Page", AreaCode = "088", PhoneNumber = "9834999" },
                new Contact { ContactId = 5, FirstName = "Jimmy", SecondName = "Joyce", AreaCode = "088", PhoneNumber = "9834567" },
                new Contact { ContactId = 6, FirstName = "Jimmy", SecondName = "Bond", AreaCode = "087", PhoneNumber = "0007007" },
                new Contact { ContactId = 7, FirstName = "Albert", SecondName = "Einstein", AreaCode = "085", PhoneNumber = "1237007" },
                new Contact { ContactId = 8, FirstName = "Isaac", SecondName = "Newton", AreaCode = "086", PhoneNumber = "2347007" },
                new Contact { ContactId = 9, FirstName = "Isaac", SecondName = "Butt", AreaCode = "087", PhoneNumber = "3457007" },
                new Contact { ContactId = 10, FirstName = "Theresa", SecondName = "Cohen", AreaCode = "088", PhoneNumber = "4567007" }
        };

        // finds contacts through index of contact
        public String findContact(string AreaCode, string PhoneNumber)
        {
            var contact = contacts.FirstOrDefault(x => x.AreaCode == AreaCode && x.PhoneNumber == PhoneNumber);
            
            if(contact == null)
            {
                return "error";
            }
            else
            {
                return "";
            }       
        }
    }
}