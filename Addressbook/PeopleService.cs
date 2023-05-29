using System;
namespace Addressbook
{
    public class PeopleService
    {
        public List<Person> People { get; set; }

        public PeopleService()
        {
            People = new List<Person>();
        }
                
        private int GetPersonId()
        {
            int personId = 0;
            do
            {
                var id = Console.ReadLine();
                Int32.TryParse(id, out personId);
                if (personId < 1)
                {
                    Console.WriteLine("You must enter the correct id!");
                }
            } while (personId < 1);
            return personId;
        }

        public int AddNewPersonView()
        {
            Console.WriteLine("Please enter id for new person: ");
            int personId = GetPersonId();
            Console.WriteLine("Please enter firstname for new person:");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter lastname for new person:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Please enter email for new person:");
            var email = Console.ReadLine();
            Console.WriteLine("Please enter phone number for new person:");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine();
            Person person = new Person();
            person.Id = personId;
            person.FirstName = firstName;
            person.LastName = lastName;
            person.Email = email;
            person.PhoneNumber = phoneNumber;
            AddNewPerson(person);
            return personId;
        }

        private void AddNewPerson(Person person)
        {            
            People.Add(person);
        }

        public void ShowAllPeople()
        {
            foreach (var person in People)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine($"{person.Id}. {person.LastName} {person.LastName}");
            }
        }

        public int RemovePersonView()
        {
            Console.WriteLine("Please enter the id of person you want to remove:");
            int personId = GetPersonId();
            RemovePerson(personId);
            return personId;
        }

        private void RemovePerson(int removeId)
        {
            foreach (var person in People)
            {
                if (person.Id == removeId)
                {
                    People.Remove(person);
                    break;
                }
            }
        }

        public int ShowPersonDetailsView()
        {
            Console.WriteLine("Please enter the id of the person you want to show:");
            int personId = GetPersonId();
            ShowPersonDetails(personId);
            return personId;
        }

        private void ShowPersonDetails(int detailsId)
        {
            foreach (var person in People)
            {
                if (person.Id == detailsId)
                {
                    Console.WriteLine("----------------------");
                    Console.WriteLine($"Id: {person.Id}");
                    Console.WriteLine($"First Name: {person.FirstName}");
                    Console.WriteLine($"Last Name: {person.LastName}");
                    Console.WriteLine($"Email: {person.Email}");
                    Console.WriteLine($"Phone Number: {person.PhoneNumber}");
                    Console.WriteLine("----------------------");
                }
            }
        }
    }
}
