using System;
using Addressbook.App.Concrete;
using Addressbook.Domain.Entity;

namespace Addressbook.App.Managers
{
    public class PeopleManager
    {
        private PeopleService _peopleService;
        public PeopleManager()
        {
            _peopleService = new PeopleService();
        }

        public int GetPersonId()
        {
            int personId = 0;
            var lastId = _peopleService.GetLastId();
            do
            {
                var id = Console.ReadLine();
                Int32.TryParse(id, out personId);
                if ((personId > lastId) || (personId < 1))
                {
                    Console.WriteLine("You must enter the correct id!");
                }
            } while ((personId > lastId) || (personId < 1));
            return personId;
        }

        public int AddNewPerson()
        {
            Console.WriteLine("Please enter firstname for new person:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter lastname for new person:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Please enter email for new person:");
            var email = Console.ReadLine();
            Console.WriteLine("Please enter phone number for new person:");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine();
            var lastId = _peopleService.GetLastId();
            Person person = new Person(lastId + 1, firstName, lastName, email, phoneNumber);
            _peopleService.AddItem(person);
            return person.Id;
        }


        public void ShowAllPeople()
        {
            foreach (var person in _peopleService.GetAllItems())
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"{person.Id}. {person.FirstName} {person.LastName}");
            }
        }

        public int RemovePerson()
        {
            Console.WriteLine("Please enter the id of person you want to remove:");
            int personId = GetPersonId();
            var person = _peopleService.GetItemById(personId);
            _peopleService.RemoveItem(person);
            return personId;
        }

        public int ShowPersonDetails()
        {
            Console.WriteLine("Please enter the id of the person you want to show:");
            int personId = GetPersonId();
            var person = _peopleService.GetItemById(personId);
            Console.WriteLine("----------------------");
            Console.WriteLine($"Id: {person.Id}");
            Console.WriteLine($"First Name: {person.FirstName}");
            Console.WriteLine($"Last Name: {person.LastName}");
            Console.WriteLine($"Email: {person.Email}");
            Console.WriteLine($"Phone Number: {person.PhoneNumber}");
            Console.WriteLine("----------------------");

            return personId;
        }
    }
}
