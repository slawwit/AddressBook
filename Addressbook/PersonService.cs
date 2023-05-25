using System;
using System.Diagnostics.Metrics;

namespace Addressbook
{
	public class PersonService
	{
		public PersonService()
		{
			People = new List<Person>();
		}
        public List<Person> People { get; set; }

		public List<Person> GetAllPeople()
		{
			return People;
		}

		public int AddNewPerson()
		{
			Person person = new Person();
			Console.WriteLine("Please enter id for new person: ");
			var id = Console.ReadLine();
			int personId;
			Int32.TryParse(id, out personId);
			Console.WriteLine("Please enter firstname for new person:");
			var firstName = Console.ReadLine();
			Console.WriteLine("Please enter lastname for new person:");
            var lastName = Console.ReadLine();
            Console.WriteLine("Please enter email for new person:");
            var email = Console.ReadLine();
            Console.WriteLine("Please enter phone number for new person:");
			var phoneNumber = Console.ReadLine();
			Console.WriteLine();
			person.Id = personId;
			person.FirstName = firstName;
			person.LastName = lastName;
			person.Email = email;
			person.PhoneNumber = phoneNumber;
			People.Add(person);
			return person.Id;
		}

		public List<Person> GetAllPersons()
		{
			return People;
		}

		public void ShowPerson()
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
			var id = Console.ReadLine();
			int personId;
			Int32.TryParse(id, out personId);

			return personId;
        }

        public void RemovePerson(int removeId)
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

        public int ShowDeatailsPersonView()
        {
			Console.WriteLine("Please enter the id of the person you want to show:");
			var personId = Console.ReadLine();
			int id;
			Int32.TryParse(personId, out id);
			return id;
        }
        

        public void ShowDetailsPerson(int detailsId)
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
                    Console.WriteLine();
                    Console.WriteLine("----------------------");
                }
			}
        }
    }
}

